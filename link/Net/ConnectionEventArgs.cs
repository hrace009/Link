using System;

namespace Link.Net
{
    public class ConnectionEventArgs
    {
        public Connection Connection { get; private set; }
        public ConnectionEventArgs()
        {
            
        }
        public ConnectionEventArgs(Connection connection)
        {
            this.Connection = connection;
        }
    }
}

