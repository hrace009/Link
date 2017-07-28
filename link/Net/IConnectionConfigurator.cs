using System;
namespace Link.Net
{
    public interface IConnectionConfigurator
    {
        void Configure(Connection connection);
    }
}
