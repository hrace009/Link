using System;
using System.Threading;
using Link.Net;

namespace Link.Modules
{
    public class RpcTask
    {
        public int Id { get; private set; }
        public IRpc Rpc { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public bool Success { get; set; }

        public ManualResetEventSlim CompleteWaiter { get; private set; }
        public bool IsComplete
        {
            get
            {
                return CompleteWaiter.IsSet;
            }
        }

        public RpcTask(int id, IRpc rpc, DateTime expire)
        {
            CompleteWaiter = new ManualResetEventSlim(false);
            Id = id;
            Rpc = rpc;
            ExpireDate = expire;
        }
    }
}

