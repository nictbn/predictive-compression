using AritmeticV2;
using BitReaderWriter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace predictive_coding
{
    public class Coder
    {
        public int k;
        public int predictor;
        public byte[] header;

        public byte[,] original;
        public byte[,] prediction;
        public int[,] predictionError;
        public int[,] quantizedPredictionError;
        public int[,] dequantizedPredictionError;
        public byte[,] decoded;
        public int[,] error;
        public string saveMode;
        const int HEADER_SIZE = 1078;
        const int WIDTH = 256;
        const int HEIGHT = 256;
        const string FIXED = "F";
        const string TABLE = "T";
        const string ARITHMETIC = "A";
        const int FIRST_ROW = 0;
        const int FIRST_COLUMN = 0;

        const int MIDDLE_OF_INTERVAL = 128;

        const int PREDICTOR_128 = 0;
        const int PREDICTOR_A = 1;
        const int PREDICTOR_B = 2;
        const int PREDICTOR_C = 3;
        const int A_B_AVERAGE = 7;
        const int PREDICTOR_JPEGLS = 8;

        public void Init()
        {
            k = 2;
            header = new byte[1078];
            original = new byte[256, 256];
            prediction = new byte[256, 256];
            predictionError = new int[256, 256];
            quantizedPredictionError = new int[256, 256];
            dequantizedPredictionError = new int[256, 256];
            decoded = new byte[256, 256];
            error = new int[256, 256];
            saveMode = "F";
        }

        public void ParseImage(string path)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.Open))
            {
                for (int i = 0; i < HEADER_SIZE; i++)
                {
                    header[i] = (byte)(fileStream.ReadByte());
                }

                for (int i = HEIGHT - 1; i >= 0; i--)
                {
                    for (int j = 0; j < WIDTH; j++)
                    {
                        original[i, j] = (byte)(fileStream.ReadByte());
                    }
                }
            }
        }

        public void Encode()
        {
            for (int i = 0; i < HEIGHT; i++)
            {
                for (int j = 0; j < WIDTH; j++)
                {
                    PredictPixel(i, j);
                    CalculatePredictionError(i, j);
                    QuantizePredictionError(i, j);
                    DequantizePredictionError(i, j);
                    DecodePixel(i, j);
                }
            }
        }

        private void PredictPixel(int i, int j)
        {
            MakePrediction(i, j);
        }

        private void MakePrediction(int i, int j)
        {
            if (predictor == PREDICTOR_128)
            {
                prediction[i, j] = MIDDLE_OF_INTERVAL;
                return;
            }
            if (i == FIRST_ROW && j == FIRST_COLUMN)
            {
                prediction[i, j] = MIDDLE_OF_INTERVAL;
                return;
            }
            if (i == FIRST_ROW)
            {
                prediction[i, j] = GetA(i, j);
                return;
            }
            if (j == FIRST_COLUMN)
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

        private void CalculatePredictionError(int i, int j)
        {
            predictionError[i, j] = original[i, j] - prediction[i, j];
        }

        private void QuantizePredictionError(int i, int j)
        {
            quantizedPredictionError[i, j] = (int)Math.Floor(1.0 * (predictionError[i, j] + k) / (2 * k + 1));
        }

        private void DequantizePredictionError(int i, int j)
        {
            dequantizedPredictionError[i, j] = quantizedPredictionError[i, j] * (2 * k + 1);
        }

        private void DecodePixel(int i, int j)
        {
            int value = dequantizedPredictionError[i, j] + prediction[i, j];
            decoded[i, j] = Normalize(value);
        }

        public void Save(string imagePath)
        {
            if (imagePath != null)
            {
                string savedFilePath = imagePath;
                savedFilePath += ".k" + k + "p" + predictor + saveMode + ".nlp";
                BitWriter writer = new BitWriter(savedFilePath);
                writer.writeNBits(k, 4);
                writer.writeNBits(predictor, 4);
                byte[] asciiBytes = Encoding.ASCII.GetBytes(saveMode);
                writer.writeNBits(asciiBytes[0], 8);
                for (int i = 0; i < HEADER_SIZE; i++)
                {
                    writer.writeNBits(header[i], 8);
                }
                if (saveMode.Equals(FIXED))
                {
                    SaveFixed(writer);
                }
                else if (saveMode.Equals(TABLE))
                {
                    SaveUsingTable(writer);
                }
                else if (saveMode.Equals(ARITHMETIC))
                {
                    SaveUsingArithmetic(writer);
                }
               
            }
        }

        private void SaveUsingArithmetic(BitWriter writer)
        {
            ArithCoder arithCoder = new ArithCoder();
            arithCoder.Encode(512, quantizedPredictionError, writer);
        }

        void SaveFixed(BitWriter writer)
        {
            for (int i = 0; i < HEIGHT; i++)
            {
                for (int j = 0; j < WIDTH; j++)
                {
                    writer.writeNBits(quantizedPredictionError[i, j], 9);
                }
            }
            writer.writeNBits(0, 7);
            writer.closeFile();
        }

        private void SaveUsingTable(BitWriter writer)
        {
            for (int i = 0; i < HEIGHT; i++)
            {
                for (int j = 0; j < WIDTH; j++)
                {
                    int currentValue = quantizedPredictionError[i, j];
                    if (currentValue == 0)
                    {
                        writer.writeBit(0);
                        continue;
                    }
                    int absoluteValue = Math.Abs(quantizedPredictionError[i, j]);
                    int numberOfOneBits = (int)Math.Log(absoluteValue, 2) + 1;

                    for (int k = 0; k < numberOfOneBits; k++)
                    {
                        writer.writeBit(1);
                    }

                    writer.writeBit(0);

                    if (currentValue > 0)
                    {
                        writer.writeNBits(currentValue, numberOfOneBits);
                    }
                    else
                    {
                        int index = (int)Math.Pow(2, numberOfOneBits) - 1 - absoluteValue;
                        writer.writeNBits(index, numberOfOneBits);
                    }
                }
            }
            writer.writeNBits(0, 7);
            writer.closeFile();
        }
    }
}
