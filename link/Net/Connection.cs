using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Link.Security;
using Link.IO;

namespace Link.Net
{
    public abstract class Connection
    {
        public event EventHandler StateChanged;
        public event ReceivedDataHandler DataReceived;

        public EncodeStack EncodeStack { get; private set; }
        public EncodeStack DecodeStack { get; private set; }

        public EncodeContainer Encoder { get; private set; }
        public EncodeContainer Decoder { get; private set; }

        public Connection()
        {
            EncodeStack = new EncodeStack();
            DecodeStack = new EncodeStack();

            Encoder = EncodeContainer.Create(EncodeStack);
            Decoder = EncodeContainer.Create(DecodeStack);
        }

        private ConnectionState state = ConnectionState.NotWorking;
        public virtual ConnectionState State
        {
            get
            {
                return state;
            }
            protected set
            {
                state = value;
                StateChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public abstract void Start();
        public abstract void Stop();
        public abstract void Close();

        public virtual bool Send(byte[] buffer, int offset, int length)
        {
            lock (EncodeStack)
            {
                Encoder.Reset();
                Encoder.Encode(buffer, offset, length);
                return ProcessSend(
                    Encoder.OutputStream.Buffer, 
                    Encoder.OutputStream.Position, 
                    Encoder.OutputStream.Count - Encoder.OutputStream.Position);
            }
        }

        protected abstract bool ProcessSend(byte[] buffer, int offset, int length);
        protected virtual void ProcessReceive(byte[] buffer, int offset, int length)
        {
            lock (DecodeStack)
            {
                Decoder.Reset();
                Decoder.Encode(buffer, offset, length);
                DataReceived?.Invoke(this, 
                    Decoder.OutputStream.Buffer, 
                    Decoder.OutputStream.Position, 
                    Decoder.OutputStream.Count - Decoder.OutputStream.Position);
            }
        }
    }
}
