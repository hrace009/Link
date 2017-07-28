using System;
using Link.Net.Protocol;

namespace Link.Net
{
    public class MitmPair
    {
        public virtual Session Client { get; internal protected set; }
        public virtual Session Server { get; internal protected set; }

        public event EventHandler Closing;
        public event EventHandler Closed;

        public ProtoListTable Proto { get; internal protected set; }

        internal void Configure()
        {
            Proto = Client.Proto;

            RouteChain.Combine(Client.InputChain, Server.OutputChain);
            RouteChain.Combine(Server.InputChain, Client.OutputChain);

            Client.StateChanged += OnStateChanged;
            Server.StateChanged += OnStateChanged;
        }
        internal protected virtual void Initialize()
        {

        }


        void OnStateChanged(object sender, EventArgs e)
        {
            OnStateChanged((Session)sender);
        }

        protected virtual void OnStateChanged(Session session)
        {
            if (session.State != SessionState.Working)
            {
                session.StateChanged -= OnStateChanged;
                Close();
            }
        }
        protected virtual void OnClosing()
        {
            Closing?.Invoke(this, EventArgs.Empty);
        }
        protected virtual void OnClosed()
        {
            Closed?.Invoke(this, EventArgs.Empty);
        }

        public virtual void Close()
        {
            OnClosing();
            Client.Close();
            Server.Close();
            OnClosed();
        }
    }
}

