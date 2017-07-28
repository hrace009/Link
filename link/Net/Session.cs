using System;
using Link.Pools;
using Link.IO;
using Link.Modules;
using Link.Net.Protocol;

namespace Link.Net
{
    public class Session
    {
        public Connection Connection { get; private set; }
        public IConnectionConfigurator ConnectionConfigurator { get; set; }

        public IPool<DataStream> DataStreamPool { get; set; }

        public PacketPolicy PacketPolicy { get; private set; }
        public PacketWriter PacketWriter { get; private set; }
        public PacketReader PacketReader { get; private set; }
        
        public PacketHandlerTable Handler { get; private set; }

        private readonly RouteOutputHandler connectionOutputRoute;
        private readonly RouteChain connectionInputRoute;
        


        public RouteSession InputChain { get; private set; }
        public RouteSession OutputChain { get; private set; }


        public event EventHandler StateChanged;
        private SessionState state = SessionState.NotWorking;
        public SessionState State
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

        public ProtoListTable Proto { get; private set; }
        public ModulesManager Modules { get; private set; }

        private object lckObject = new object();

        public Session(
            IPool<DataStream> dataStreamPool = null, 
            PacketReader packetReader = null, 
            PacketWriter packetWriter = null,
            PacketPolicy packetPolicy = null,
            ProtoListTable baseProto = null)
        {
            if (dataStreamPool == null) 
                dataStreamPool = Link.Pools.DataStreamPool.Instance;
            if (packetReader == null) 
                packetReader = new PacketReader(dataStreamPool.Take(), dataStreamPool.Take());
            if (packetWriter == null)
                packetWriter = new PacketWriter(dataStreamPool.Take(), dataStreamPool.Take());
            if (packetPolicy == null)
                packetPolicy = PacketPolicy.AllAcceptPolicy;

            DataStreamPool = dataStreamPool;
            PacketReader = packetReader;
            PacketWriter = packetWriter;
            PacketPolicy = packetPolicy;

            if (baseProto == null)
            {
                Proto = new ProtoListTable();
            }
            else
            {
                Proto = baseProto;
            }

            Handler = new PacketHandlerTable();
            Handler.Proto = Proto;
            Modules = new ModulesManager(this);

            connectionInputRoute = new RouteChain();
            connectionOutputRoute = new RouteOutputHandler(SendNext);

            InputChain = new RouteSession();
            OutputChain = new RouteSession();

            InputChain.Handler = OutputChain.Handler = Handler;
            InputChain.Session = OutputChain.Session = this;

            connectionInputRoute.Next = InputChain;
            OutputChain.Next = connectionOutputRoute;

            InputChain.IsInput = true;
            OutputChain.IsInput = false;

            InputChain.Redirect = OutputChain;
            OutputChain.Redirect = InputChain;
        }

        public void SetupConnection(Connection connection, bool start = true)
        {
            if (Connection != null)
            {
                Close();
            }
            lock (lckObject)
            {
                ConnectionConfigurator?.Configure(connection);

                Connection = connection;
                Connection.StateChanged += Connection_StatusChanged;
                Connection.DataReceived += ProcessReceivedData;

                PacketReader.Clear();
                State = SessionState.Working;

                if (start)
                {
                    Start();
                }
            }
        }

        public virtual void Start()
        {
            Connection.Start();
        }
        public virtual void Close()
        {
            Connection?.Stop();
            Connection?.Close();
        }

        private void Connection_StatusChanged(object sender, EventArgs e)
        {
            lock (lckObject)
            {
                if (Connection.State == ConnectionState.Closed)
                {
                    Connection.DataReceived -= ProcessReceivedData;
                    Connection.StateChanged -= Connection_StatusChanged;

                    if (object.ReferenceEquals(sender, Connection))
                    {
                        PacketReader.Clear();
                        State = SessionState.Closed;
                    }
                }
            }
        }

        public Packet GetPacket(uint id)
        {
            return GetPacket(id, DataStreamPool.Take());
        }
        public Packet GetPacket(uint id, IDataSerializer packet)
        {
            return GetPacket(id, DataStreamPool.Take(), packet);
        }
        public Packet GetPacket(uint id, DataStream stream, IDataSerializer packet)
        {
            var res = GetPacket(id, stream);
            res.WritePacket(packet);
            return res;
        }
        public Packet GetPacket(uint id, DataStream stream)
        {
            stream.IsLittleEndian = false;
            return new PacketProto(id, stream, Proto);
        }
        public Packet GetPacket<T>(T packet) where T : IDataSerializer
        {
            var info = Proto.GetInfo<T>();
            if (info == null)
            {
                throw new NullReferenceException("Unknwon packet");
            }
            return GetPacket(info.Id, packet);
        }
        public Packet GetPacket<T>(T packet, DataStream stream) where T : IDataSerializer
        {
            var info = Proto.GetInfo<T>();
            if (info == null)
            {
                throw new NullReferenceException("Unknwon packet");
            }
            return GetPacket(info.Id, stream, packet);
        }

        public PacketWriter TakeWriter()
        {
            var writer = new PacketWriter(DataStreamPool.Take(), DataStreamPool.Take());
            return writer;
        }
        public void ReturnWriter(PacketWriter writer)
        {
            DataStreamPool.Return(writer.NetworkStream);
            DataStreamPool.Return(writer.PacketStream);
        }
        
        public void Send<T>(T packet) where T : IDataSerializer
        {
            var info = Proto.GetInfo<T>();
            if (info == null)
            {
                throw new NullReferenceException("Unknwon packet");
            }
            Send(info.Id, packet);
        }
        public void Send(uint packetId, IDataSerializer packet)
        {
            Packet pck = GetPacket(packetId);
            pck.WritePacket(packet);
            Send(pck);
            DataStreamPool.Return(pck.Stream);
        }
        public void Send(uint packetId, DataStream packetStream)
        {
            Send(GetPacket(packetId, packetStream));
        }
        public void Send(Packet packet)
        {
            OutputChain?.Send(packet);
        }
        private bool SendNext(object sender, Packet packet)
        {
            lock (PacketWriter)
            {
                PacketWriter.Clear();
                PacketWriter.Write(packet);
                return Send(PacketWriter);
            }
        }


        public bool Send(PacketWriter packetWriter)
        {
            return Send(packetWriter.GetBuffer());
        }
        public bool Send(ArraySegment<byte> buffer)
        {
            return Send(buffer.Array, buffer.Offset, buffer.Count);
        }
        public bool Send(byte[] buffer)
        {
            return Send(buffer, 0, buffer.Length);
        }
        public bool Send(byte[] buffer, int offset, int length)
        {
            return Connection?.Send(buffer, offset, length) ?? false;
        }

        private bool CheckConnection(Connection connection)
        {
            lock (lckObject)
            {
                return object.ReferenceEquals(connection, Connection);
            }
        }

        private void ProcessReceivedPacket(Packet packet)
        {
            InputChain?.Send(packet);
        }
        private void ProcessReceivedData(object sender, byte[] buffer, int offset, int length)
        {
            var connection = (Connection)sender;
            if (!CheckConnection(connection))
            {
                return;
            }
            PacketReader.PushBack(buffer, offset, length);

            while (PacketReader.ReadNext())
            {
                if (!CheckConnection(connection))
                {
                    return;
                }
                switch (PacketReader.State)
                {
                    case PacketReaderState.Complete:
                        {
                            var packet = GetPacket(PacketReader.PacketId, PacketReader.PacketStream);
                            var policyResult = PacketPolicy.CheckPacket(packet);
                            PacketReader.UpdatePolicy(policyResult);

                            if (policyResult == PacketPolicyState.Drop)
                            {
                                Close();
                                return;
                            }
                            if (policyResult == PacketPolicyState.Reject)
                            {
                                continue;
                            }

                            ProcessReceivedPacket(packet);
                        }
                        continue;
                    case PacketReaderState.WaitingContent:
                        {
                            var policyResult = PacketPolicy.CheckLength(PacketReader.PacketId, PacketReader.PacketLength);
                            PacketReader.UpdatePolicy(policyResult);

                            if (policyResult == PacketPolicyState.Drop)
                            {
                                Close();
                                return;
                            }
                        }
                        continue;
                    case PacketReaderState.WaitingLength:
                        {
                            var policyResult = PacketPolicy.CheckId(PacketReader.PacketId);
                            PacketReader.UpdatePolicy(policyResult);

                            if (policyResult == PacketPolicyState.Drop)
                            {
                                Close();
                                return;
                            }
                        }
                        continue;
                }
            }

        }
    }
}

