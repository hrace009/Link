using System;
using Link.IO;

namespace Link.Security
{
    public struct EncodeContainer
    {
        public DataStream OutputStream { get; private set; }
        public StreamEncoder Encoder { get; private set; }

        public EncodeContainer(StreamEncoder encoder, DataStream outputStream)
        {
            Encoder = encoder;
            OutputStream = outputStream;
        }
        public void Encode(DataStream inputStream)
        {
            Encoder.Encode(inputStream, OutputStream);
        }
        public void Encode(byte[] buffer)
        {
            Encoder.Encode(buffer, OutputStream);
        }
        public void Encode(byte[] buffer, int offset, int length)
        {
            Encoder.Encode(buffer, offset, length, OutputStream);
        }
        public void Reset()
        {
            OutputStream.Clear();
        }

        public static EncodeContainer Create(StreamEncoder encoder)
        {
            return new EncodeContainer(encoder, new DataStream());
        }
    }
}

