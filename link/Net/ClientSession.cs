using System;
using Link.Pools;
using Link.IO;
using Link.Modules;

namespace Link.Net
{
    public class ClientSession : Session
    {
        public Connector Connector { get; private set; }

        public ClientSession(string server,
            IPool<DataStream> dataStreamPool = null, 
            PacketReader packetReader = null, 
            PacketWriter packetWriter = null,
            PacketPolicy packetPolicy = null) : base(dataStreamPool, packetReader, packetWriter, packetPolicy)
        {
            Initialize(new TcpSocketOpener(server));
        }

        public ClientSession(IPassiveConnectionFactory factory,
            IPool<DataStream> dataStreamPool = null, 
            PacketReader packetReader = null, 
            PacketWriter packetWriter = null,
            PacketPolicy packetPolicy = null) : base(dataStreamPool, packetReader, packetWriter, packetPolicy)
        {
            Initialize(factory);
        }
        private void Initialize(IPassiveConnectionFactory factory)
        {
            Connector = Modules.Register<Connector>();
            Connector.ConnectionFactory = factory;
        }

        public void Connect()
        {
            Connector.Connect();
        }
        public override void Close()
        {
            Connector.Close();
        }
    }
}

