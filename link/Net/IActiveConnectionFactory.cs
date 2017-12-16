using System;

namespace Link.Net
{
    public interface IActiveConnectionFactory
    {
        event ConnectionEventHandler ConnectionAccept;
        bool Started { get; }
        void Start();
        void Stop();
        void Free(Connection connection);
    }
}

