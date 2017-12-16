using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Link.Threading
{
    class TaskResultAsyncContainer<T> : IAsyncResult
    {
        public ManualResetEventSlim ResetEvent { get; } = new ManualResetEventSlim(false);
        public T Result { get; private set; }
        public Task<T> ResultTask { get; private set; }

        public TaskResultAsyncContainer()
        {
            ResultTask = Task.Factory.FromAsync(this, ResultMethod);
        }

        public void SetResult(T result)
        {
            Result = result;
            ResetEvent.Set();
        }
        private T ResultMethod(IAsyncResult e)
        {
            return Result;
        }

        public object AsyncState => null;

        public WaitHandle AsyncWaitHandle => ResetEvent.WaitHandle;

        public bool CompletedSynchronously => false;

        public bool IsCompleted => ResetEvent.IsSet;
    }
}
