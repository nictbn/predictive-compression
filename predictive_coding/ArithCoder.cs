using BitReaderWriter;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmeticV2
{
    class ArithCoder
    {
        const uint TOP_VALUE = 0xFFFFFFFF;
        const uint FIRST_QTR = 1u << 30;
        const uint HALF = 1u << 31;
        const uint THIRD_QTR = HALF | FIRST_QTR;
        BitWriter writer;
        ArithModel model;
        uint low;
        uint high;
        int bits_to_follow;

        //extra stuff

        public void Encode(int numberOfCharactersForModel, int[,] quantizedPredictionError, BitWriter writer)
        {
            model = new ArithModel(numberOfCharactersForModel);
            model.start_model();
            start_outputing_bits(writer);
            start_encoding();
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    int ch = quantizedPredictionError[i, j] + 255;
                    int symbol;
                    symbol = model.char_to_index[ch];
                    encode_symbol(symbol, model.cumulative_frequencies);
                    model.update_model(symbol);
                }
            }
            encode_symbol(model.eof_symbol, model.cumulative_frequencies);
            done_encoding();
            done_outputing_bits();

        }

        private void done_outputing_bits()
        {
            writer.writeNBits(0, 7);
            writer.closeFile();
        }

        private void done_encoding()
        {
            bits_to_follow += 1;
            if (low < FIRST_QTR)
            {
                bit_plus_follow(0);
            }
            else
            {
                bit_plus_follow(1);
            }
        }

        private void encode_symbol(int symbol, int[] cumulative_frequencies)
        {
            ulong range;
            range = (ulong)(high - low) + 1;
            high = (uint)(low + (range * (ulong)cumulative_frequencies[symbol - 1]) / (ulong)cumulative_frequencies[0] - 1);
            low = (uint)(low + (range * (ulong)cumulative_frequencies[symbol]) / (ulong)cumulative_frequencies[0]);
            int loop_index = 0;
            for (; ; )
            {
                if (high < HALF)
                {
                    bit_plus_follow(0);
                }
                else if (low >= HALF)
                {
                    bit_plus_follow(1);
                    low -= HALF;
                    high -= HALF;
                }
                else if (low >= FIRST_QTR && high < THIRD_QTR)
                {
                    bits_to_follow += 1;
                    low -= FIRST_QTR;
                    high -= FIRST_QTR;
                }
                else break;
                low = 2 * low;
                high = 2 * high + 1;
                loop_index++;
            }
        }

        private void bit_plus_follow(int v)
        {
            writer.writeBit(v);
            while (bits_to_follow > 0)
            {
                writer.writeBit(~v);
                bits_to_follow -= 1;
            }
        }

        private void start_outputing_bits(BitWriter writer)
        {
            this.writer = writer;
        }

        private void start_encoding()
        {
            low = 0u;
            high = TOP_VALUE;
            bits_to_follow = 0;
        }
    }


}
