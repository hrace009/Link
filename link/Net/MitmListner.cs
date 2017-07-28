using System;

namespace Link.Net
{
    public class MitmListner<T> where T : MitmPair, new()
    {
        public IActiveConnectionFactory ActiveFactory { get; private set; }
        public IPassiveConnectionFactory PassiveFactory { get; private set; }

        public event MitmPairEventHandler<T> Accepting;
        public event MitmPairEventHandler<T> Accepted;

        public MitmListner(IActiveConnectionFactory activeFactory, IPassiveConnectionFactory passiveFactory)
        {
            ActiveFactory = activeFactory;
            PassiveFactory = passiveFactory;

            ActiveFactory.ConnectionAccept += ActiveFactory_ConnectionAccept;
        }

        private void ActiveFactory_ConnectionAccept (object sender, ConnectionEventArgs client)
        {
            Connection server;
            try
            {
                server = PassiveFactory.Take();
            }
            catch
            {
                ActiveFactory.Free(client.Connection);
                return;
            }
            ProcessConnections(client.Connection, server);
        }
        public void Start()
        {
            ActiveFactory.Start();
        }
        public void Stop()
        {
            ActiveFactory.Stop();
        }
        protected virtual void ProcessConnections(Connection client, Connection server)
        {
            try
            {
                var pair = MakePair();
                ConfigurePair(pair);

                pair.Client.SetupConnection(client, false);
                pair.Server.SetupConnection(server, false);

                Accepting?.Invoke(this, pair);

                pair.Initialize();
                pair.Client.Start();
                pair.Server.Start();

                Accepted?.Invoke(this, pair);
            }
            catch
            {
                ActiveFactory.Free(client);
                PassiveFactory.Free(server);
            }
        }
        protected virtual T MakePair()
        {
            return new T();
        }
        protected virtual void ConfigurePair(T pair)
        {
            var clientSession = new Session();
            var serverSession = new Session(baseProto: clientSession.Proto);

            pair.Client = clientSession;
            pair.Server = serverSession;
            pair.Configure();
        }
    }
}

