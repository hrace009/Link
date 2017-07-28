using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesCodeGen.Coding
{
    public abstract class CodeBuilder<T>
    {
        protected const int DefaultPriority = 0;
        protected const int IgnorePriority = -1;

        protected int BuildPriority(bool[] filters, bool[] values)
        {
            if (filters.Length != values.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            var priority = 0;
            for (var i = 0; i < filters.Length && priority != IgnorePriority; i++)
            {
                priority = PriorityUpdate(priority, filters[i], values[i], 1 << i);
            }
            return priority;
        }
        protected int PriorityUpdate(int current, bool filter, bool value, int priority)
        {
            if (current == IgnorePriority)
            {
                return IgnorePriority;
            }
            if (filter)
            {
                if (value) return current + priority;
                else return IgnorePriority;
            }
            return current;
        }

        public abstract int GetPriority(T value, CodeGeneration generation);
        public abstract string Build(T value, CodeGeneration generation);
    }
}
