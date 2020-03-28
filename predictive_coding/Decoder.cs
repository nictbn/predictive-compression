using BitReaderWriter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace predictive_coding
{
    public class Decoder
    {
        const int PREDICTOR_128 = 0;
        const int MIDDLE_OF_INTERVAL = 128;
        const int PREDICTOR_A = 1;
        const int PREDICTOR_B = 2;
        const int PREDICTOR_C = 3;
        const int A_B_AVERAGE = 7;
        const int PREDICTOR_JPEGLS = 8;

        const int HEADER_LENGTH = 1078;
        const int HEIGHT = 256;
        const int WIDTH = 256;
        const int FIRST_ROW = 0;
        const int FIRST_COLUMN = 0;

        public string codedImagePath;
        public int[,] quantizedPredictionError;
        int[,] dequantizedPredictionError;
        public byte[,] decoded;
        byte[] header;
        string saveMode;
        int k;
        int predictor;
        BitReader reader;
        byte[,] prediction;
        
        public void Init()
        {
            codedImagePath = null;
            quantizedPredictionError = new int[256, 256];
            dequantizedPredictionError = new int[256, 256];
            decoded = new byte[256, 256];
            header = new byte[1078];
            saveMode = null;
            k = 0;
            prediction = new byte[256, 256];
        }

        public void Decode()
        {
            if (codedImagePath == null)
            {
                return;
            }

            reader = new BitReader(codedImagePath);
            k = reader.readNBits(4);
            predictor = reader.readNBits(4);
            char c = (char) reader.readNBits(8);
            saveMode = c.ToString();

            for (int i = 0; i < HEADER_LENGTH; i++)
            {
                header[i] = (byte)reader.readNBits(8);
            }

            if (saveMode.Equals("F"))
            {
                PopulateQuantizedPredictionErrorFromSaveModeFixed();
            }
            
            reader.closeFile();

            DequantizePredictionError();

            for(int i = 0; i < HEIGHT; i++)
            {
                for (int j = 0; j < WIDTH; j++)
                {
                    MakePrediction(i, j);
                    SetPixelInDecodedMatrix(i, j);
                }
            }
        }

        private void SetPixelInDecodedMatrix(int i, int j)
        {
            int result = prediction[i, j] + dequantizedPredictionError[i, j];
            decoded[i, j] = Normalize(result);
        }

        private void MakePrediction(int i, int j)
        {
            if(predictor == PREDICTOR_128)
            {
                prediction[i,j] = MIDDLE_OF_INTERVAL;
                return;
            }
            if(i == FIRST_ROW && j == FIRST_COLUMN)
            {
                prediction[i, j] = MIDDLE_OF_INTERVAL;
                return;
            }
            if(i == FIRST_ROW)
            {
                prediction[i, j] = GetA(i, j);
                return;
            }
            if(j == FIRST_COLUMN)
            {
                prediction[i, j] = GetB(i, j);
                return;
            }
            int value;
            switch (predictor)
            {
                case PREDICTOR_A:
                    prediction[i, j] = GetA(i, j);
                    break;
                case PREDICTOR_B:
                    prediction[i, j] = GetB(i, j);
                    break;
                case PREDICTOR_C:
                    prediction[i, j] = GetC(i, j);
                    break;
                case 4:
                    value = GetA(i, j) + GetB(i, j) - GetC(i, j);
                    prediction[i, j] = Normalize(value);
                    break;
                case 5:
                    value = GetA(i, j) + (GetB(i, j) - GetC(i, j)) / 2;
                    prediction[i, j] = Normalize(value);
                    break;
                case 6:
                    value = GetB(i, j) + (GetA(i, j) - GetC(i, j)) / 2;
                    prediction[i, j] = Normalize(value);
                    break;
                case A_B_AVERAGE:
                    value = (GetA(i, j) + GetB(i, j)) / 2;
                    prediction[i, j] = Normalize(value);
                    break;
                case PREDICTOR_JPEGLS:
                    value = jpegls(i, j);
                    prediction[i, j] = Normalize(value);
                    break;
            }
        }

        private int jpegls(int i, int j)
        {
            if (GetC(i, j) >= Math.Max(GetA(i, j), GetB(i, j)))
            {
                return Math.Min(GetA(i, j), GetB(i, j));
            }
            else if (GetC(i, j) <= Math.Min(GetA(i, j), GetB(i, j)))
            {
                return Math.Max(GetA(i, j), GetB(i, j));
            }
            else
            {
                return GetA(i, j) + GetB(i, j) - GetC(i, j);
            }
        }

        private byte GetA(int i, int j)
        {
            return decoded[i, j - 1];
        }

        private byte GetB(int i, int j)
        {
            return decoded[i - 1, j];
        }

        private byte GetC(int i, int j)
        {
            return decoded[i - 1, j - 1];
        }

        private byte Normalize(int value)
        {
            if (value > 255)
            {
                value = 255;
            }
            if (value < 0)
            {
                value = 0;
            }
            return (byte)value;
        }

        private void DequantizePredictionError()
        {
            for(int i = 0; i < HEIGHT; i++)
            {
                for(int j = 0; j < WIDTH; j++)
                {
                    dequantizedPredictionError[i, j] = quantizedPredictionError[i, j] * (2 * k + 1);
                }
            }
        }

        private void PopulateQuantizedPredictionErrorFromSaveModeFixed()
        {
            for (int i = 0; i < HEIGHT; i++)
            {
                for (int j = 0; j < WIDTH; j++)
                {
                    int currentValue = reader.readNBits(9);
                    quantizedPredictionError[i, j] = ExtendSign(currentValue);
                }
            }
        }

        private int ExtendSign(int value)
        {
            int sign = 1 << 8;
            sign &= value;
            int position = 9;
            while (position < 32)
            {
                sign = sign << 1;
                value |= sign;
                position++;
            }
            return value;
        }

        internal void Save()
        {
            if(codedImagePath == null)
            {
                return;
            }
            string savePath = codedImagePath + ".bmp";
            BitWriter writer = new BitWriter(savePath);
            for(int i = 0; i < HEADER_LENGTH; i++)
            {
                writer.writeNBits(header[i], 8);
            }

            for(int i = HEIGHT - 1; i >= 0; i--)
            {
                for(int j = 0; j < WIDTH; j++)
                {
                    writer.writeNBits(decoded[i, j], 8);
                }
            }
            writer.closeFile();
            return;
        }
    }
}
