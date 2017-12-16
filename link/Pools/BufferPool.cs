using System;
using System.Threading;

namespace Link.Pools
{
    public class BufferPool : StackPool<ArraySegment<byte>>
    {
        const int HeaderSize = 8;

        private static int idCounter = 1;
        private readonly int Id;

        public int DefaultSize { get; private set; }
        public bool FixedSize { get; private set; }
        public BufferPool(int defaultSize, bool fixedSize = false, int maxFreeCount = 1024, int allocateDefaultCount = 16) : base(maxFreeCount, allocateDefaultCount)
        {
            DefaultSize = defaultSize;
            FixedSize = fixedSize;
            Id = Interlocked.Increment(ref idCounter);
        }

        public override ArraySegment<byte> Create()
        {
            if (DefaultSize <= 0)
            {
                return new ArraySegment<byte>();
            }
            return new ArraySegment<byte>(new byte[DefaultSize]);
        }

        private unsafe bool Validate(byte[] buffer)
        {
            fixed (byte* bytePtr = buffer)
            {
                int* ptr = (int*)bytePtr;
                int id = ptr[1];

                if (id != Id)
                {
                    int count = ptr[0];
                    if (count == 0)
                    {
                        ptr[1] = id = Id;
                    }
                }
                return id == Id;
            }
        }
        private unsafe int Change(byte[] buffer, int value)
        {
            fixed (byte* bytePtr = buffer)
            {
                int* ptr = (int*)bytePtr;
                ptr[0] += value;
                return ptr[0];
            }
        }

        public override ArraySegment<byte> Take()
        {
            lock (base.LockObject)
            {
                var result = base.Take();
                Change(result.Array, -1);

                return result;
            }
        }
        public new bool Return(ArraySegment<byte> element)
        {
            return Return(element.Array, element.Offset, element.Count);
        }
        public virtual bool Return(byte[] buffer, int offset, int count)
        {
            if (DefaultSize <= 0)
                return false;
            if (buffer.Length <= HeaderSize)
            {
                return false;
            }
            if (offset < HeaderSize)
            {
                count = count - HeaderSize + offset;
                offset = HeaderSize;
            }
            if (count < DefaultSize)
            {
                return false;
            }
            if (!Validate(buffer))
            {
                return false;
            }
            var ok = false;
            lock (base.LockObject)
            {
                var needReturn = base.FreeItems.Count < base.MaxFreeCount;
                if (!needReturn)
                {
                    int cnt = Change(buffer, 0);
                    if (cnt > 0)
                    {
                        needReturn = true;
                    }
                }
                if (needReturn)
                {
                    int resCount = 0;
                    for (var i = 0; i < count; i += DefaultSize)
                    {
                        var curOffset = offset + i;
                        var curCount = DefaultSize;
                        if (!FixedSize && i + (DefaultSize << 1) > count)
                        {
                            curCount = count - i;
                        }
                        if (curCount > count - i)
                        {
                            break;
                        }
                        if (base.Return(new ArraySegment<byte>(buffer, curOffset, curCount), true))
                        {
                            resCount++;
                            ok = true;
                        }
                    }
                    Change(buffer, resCount);
                }
            }
            return ok;
        }
        public override void Allocate(int count)
        {
            var buffer = new byte[HeaderSize + count * DefaultSize];
            Return(buffer, 0, buffer.Length);
        }
    }
}

