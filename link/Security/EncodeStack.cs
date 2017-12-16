using System;
using System.Collections.Generic;
using Link.IO;
using System.Linq;

namespace Link.Security
{
    public class EncodeStack : StreamEncoder
    {
        public Stack<EncodeContainer> Stack { get; private set; }
        public EncodeStack()
        {
            Stack = new Stack<EncodeContainer>();
        }

        public void Setup(StreamEncoder encoder)
        {
            Setup(EncodeContainer.Create(encoder));
        }
        public void Setup(EncodeContainer encodeContainer)
        {
            Stack.Push(encodeContainer);
        }
        public EncodeContainer Setdown()
        {
            return Stack.Pop();
        }
        public override void Encode(byte[] buffer, int offset, int length, DataStream output)
        {
            foreach (var encoder in Stack.Reverse())
            {
                encoder.Reset();
                encoder.Encode(buffer, offset, length);

                buffer = encoder.OutputStream.Buffer;
                offset = encoder.OutputStream.Position;
                length = encoder.OutputStream.Count;
            }
            output.PushBack(buffer, offset, length);
        }
    }
}

