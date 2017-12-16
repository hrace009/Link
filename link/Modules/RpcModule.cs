using System;
using System.Threading;
using System.Collections.Generic;
using Link.Net;
using Link.IO;

namespace Link.Modules
{
    public class RpcModule : ModuleBase
    {
        private static Comparer<RpcTask> RpcExpireComparer = Comparer<RpcTask>.Create((a, b) => {
            var t = a.ExpireDate.CompareTo(b.ExpireDate);
            if (t == 0)
            {
                t = a.Id.CompareTo(b.Id);
            }
            return t;
        });

        private object lck = new object();
        private int idCounter = 1;

        private SortedSet<RpcTask> UncompleteSet;
        private Dictionary<int, RpcTask> UncompleteTasks;

        private HashSet<uint> RpcIds;

        public RpcModule()
        {
            UncompleteSet = new SortedSet<RpcTask>(RpcExpireComparer);
            UncompleteTasks = new Dictionary<int, RpcTask>();
            RpcIds = new HashSet<uint>();
        }

        public override void Initialize()
        {
            Session.Handler.Get().Add(OnPacketReceive, PacketHandlerPriority.System);
        }
        public override void Destroy()
        {
            Session.Handler.Get().Remove(OnPacketReceive);
        }

        private void OnPacketReceive(object sender, PacketEventArgs e)
        {
            if (e.Chain.IsInput && !e.IsComplete)
            {
                if (RpcIds.Contains(e.Packet.Id))
                {
                    var rpcIdValue = e.Packet.Stream.Reset().ReadUInt32();

                    var rpcId = rpcIdValue & 0x7FFFFFFF;

                    if (rpcId != rpcIdValue)
                    {
                        
                    }
                }
                Flush();
            }
        }

        public void RegisterTask(RpcTask task)
        {
            lock (lck)
            {
                UncompleteSet.Add(task);
                UncompleteTasks[task.Id] = task;
            }
        }
        public void Clear()
        {
            lock (lck)
            {
                RpcIds.Clear();
                while (UncompleteSet.Count > 0)
                {
                    ProcessCompleteTask(UncompleteSet.Min);
                }
                UncompleteSet.Clear();
                UncompleteTasks.Clear();
            }
        }

        public void Flush()
        {
            lock (lck)
            {
                while (UncompleteSet.Count > 0 && UncompleteSet.Min.ExpireDate < DateTime.Now)
                {
                    var value = UncompleteSet.Min;
                    ProcessCompleteTask(value);
                }
            }
        }
        private void ProcessCompleteTask(RpcTask task)
        {
            lock (lck)
            {
                UncompleteSet.Remove(task);
                UncompleteTasks.Remove(task.Id);
                task.CompleteWaiter.Set();
            }
        }
        public RpcTask CreateTask(IRpc rpc, DateTime expire)
        {
            int id = Interlocked.Increment(ref idCounter) & 0x7FFFFFFF;
            return new RpcTask(id, rpc, expire);
        }

        public RpcTask Send(uint packetId, IRpc rpc, int timeout = 60000)
        {
            var expire = DateTime.Now.AddMilliseconds(timeout);
            if (timeout == -1)
            {
                expire = DateTime.MaxValue;
            }
            return Send(packetId, rpc, expire);
        }
        public RpcTask Send(uint packetId, IRpc rpc, DateTime expire)
        {
            var task = CreateTask(rpc, expire);
            return Send(packetId, task);
        }
        public RpcTask Send(uint packetId, RpcTask task)
        {
            if (task.ExpireDate < DateTime.Now)
            {
                ProcessCompleteTask(task);
                return task;
            }
            var container = new RpcContainer(task.Rpc.Argument);
            container.Id = (uint)task.Id;

            lock (lck)
            {
                RpcIds.Add(packetId);
            }
            RegisterTask(task);

            Session.Send(packetId, container);
            return task;
        }
    }
}

