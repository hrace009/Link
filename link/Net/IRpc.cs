using System;
using Link.IO;

namespace Link.Net
{
    public interface IRpc<TArgument, TResult> : IRpc
        where TArgument : IDataSerializer
        where TResult : IDataSerializer
    {
        new TArgument Argument { get; }
        new TResult Result { get; }
    }
    public interface IRpc
    {
        IDataSerializer Argument { get; }
        IDataSerializer Result { get; }
    }
}

