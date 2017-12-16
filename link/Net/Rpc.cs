using System;
using Link.IO;

namespace Link.Net
{
    public class Rpc<TArgument, TResult> : IRpc<TArgument, TResult>
        where TArgument : IDataSerializer
        where TResult : IDataSerializer
    {
        public TArgument Argument { get; private set; }
        public TResult Result { get; private set; }

        public Rpc()
        {
            Argument = Helpers.FastConstructor<TArgument>.Create();
            Result = Helpers.FastConstructor<TResult>.Create();
        }

        IDataSerializer IRpc.Argument { get { return Argument; } }
        IDataSerializer IRpc.Result { get { return Result; } }
    }
}

