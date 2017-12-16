using System;
using Link.Net;

namespace Link.Modules
{
    public class Connector : ModuleBase
    {
        public event EventHandler StateChanged;
        private ConnectorState state;
        public ConnectorState State
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
        private object lckObj = new object();

        public IPassiveConnectionFactory ConnectionFactory { get; set; }

        public override void Initialize()
        {
            Session.StateChanged += Session_StateChanged;
        }
        public override void Destroy()
        {
            Session.StateChanged -= Session_StateChanged;
        }

        protected void Session_StateChanged(object sender, EventArgs e)
        {
            lock (lckObj)
            {
                if (Session.State == SessionState.Working)
                {
                    State = ConnectorState.Connected;
                }
                else
                {
                    var connection = Session.Connection;
                    ConnectionFactory.Free(connection);
                    connection = null;
                    State = ConnectorState.Disconnected;
                }
            }
        }

        public bool Connect()
        {
            if (!Enabled)
                return false;
            lock (lckObj)
            {
                if (State != ConnectorState.Disconnected)
                {
                    return false;
                }
                State = ConnectorState.Connecting;
            }
            Connection connection = null;
            try
            {
                connection = ConnectionFactory.Take();
                if (connection == null)
                {
                    return false;
                }
            }
            catch
            {
                State = ConnectorState.Disconnected;
            }
            if (connection != null)
            {
                try
                {
                    Session.SetupConnection(connection);
                    return true;
                }
                catch
                {
                    ConnectionFactory.Free(connection);
                }
            }
            return false;
        }
        public void Close()
        {
            if (!Enabled)
                return;
            ConnectionFactory.Free(Session.Connection);
        }
    }
}

