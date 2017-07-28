using Link.IO;

namespace Link.Security
{
    public class MppcPacker : StreamEncoder
    {
        private static byte[] reversedBits;
        static MppcPacker()
        {
            reversedBits = new byte[256];
            for (var i = 0; i < 256; i++)
            {
                byte x = (byte)i;
                byte y = 0;
                for (var j = 0; j < 8; j++)
                {
                    y <<= 1;
                    y |= (byte)(x & 1);
                    x >>= 1;
                }
                reversedBits[i] = y;
            }
        }

        public static void PackBlock(byte[] src, int offset, int length, DataStream ds)
        {
            int histLength = 0;
            PackBlock(src, offset, length, ds, ref histLength);
        }
        public static void PackBlock(byte[] src, int offset, int length, DataStream ds, ref int histLength)
        {
            ulong x = 0;
            int pos = 0;

            for (var i = 0; i < length; ++i)
            {
                if (histLength >= 8192)
                {
                    histLength = 0;
                    x = x | (15U << pos);
                    pos += 10;
                    pos += -(pos & 7) & 7;
                }
                ulong v = reversedBits[src[offset + i]];
                if ((v & 1) > 0)
                {
                    v ^= 1;
                    x |= (1U << pos);
                    ++pos;
                }
                x |= (v << pos);
                pos += 8;
                ++histLength;
                while (pos >= 8)
                {
                    ds.PushBack(reversedBits[(int)(x & 255)]);
                    x >>= 8;
                    pos -= 8;
                }
            }
            x = x | (15U << pos);
            pos += 10;
            pos += -(pos & 7) & 7;
            while (pos >= 8)
            {
                ds.PushBack(reversedBits[(x & 255)]);
                x >>= 8;
                pos -= 8;
            }
        }

        private int HistoryLength = 0;
        public override void Encode(byte[] src, int offset, int length, DataStream ds)
        {
            PackBlock(src, offset, length, ds, ref HistoryLength);
        }
        public void Reset()
        {
            HistoryLength = 0;
        }
    }
}