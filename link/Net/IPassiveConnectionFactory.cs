using System;

namespace Link.Net
{
    public interface IPassiveConnectionFactory
    {
        Connection Take();
        void Free(Connection connection);
    }
}

