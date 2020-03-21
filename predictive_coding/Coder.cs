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
        public int[,] prediction;
        public int[,] predictionError;
        public int[,] quantizedPredictionError;
        public int[,] dequantizedPredictionError;
        public byte[,] decoded;
        public int[,] error;

        const int HEADER_SIZE = 1078;
        const int WIDTH = 256;
        const int HEIGHT = 256;

        public void Init()
        {
            header = new byte[1078];
            original = new byte[256, 256];
            prediction = new int[256, 256];
            predictionError = new int[256, 256];
            quantizedPredictionError = new int[256, 256];
            dequantizedPredictionError = new int[256, 256];
            decoded = new byte[256, 256];
            error = new int[256, 256];
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
                        original[i,j] = (byte)(fileStream.ReadByte());
                    }
                }
            }
        }

        public void Encode()
        {

        }
    }
}
