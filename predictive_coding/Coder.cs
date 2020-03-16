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
        public byte[,] OriginalImage;
        public byte[] Header;
        const int HEADER_SIZE = 1078;
        const int WIDTH = 256;
        const int HEIGHT = 256;

        public void Init()
        {
            Header = new byte[1078];
            OriginalImage = new byte[256, 256];
        }

        public void ParseImage(string path)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.Open))
            {
                for (int i = 0; i < HEADER_SIZE; i++)
                {
                    Header[i] = (byte)(fileStream.ReadByte());
                }

                for (int i = HEIGHT - 1; i >= 0; i--)
                {
                    for (int j = 0; j < WIDTH; j++)
                    {
                        OriginalImage[i,j] = (byte)(fileStream.ReadByte());
                    }
                }
            }
        }
    }
}
