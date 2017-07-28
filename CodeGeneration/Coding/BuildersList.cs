using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesCodeGen.Coding
{
    public class BuildersList<T> : CodeBuilder<T>
    {
        public List<CodeBuilder<T>> Builders { get; private set; } = new List<CodeBuilder<T>>();

        public CodeBuilder<T> GetBuilder(T value, CodeGeneration generation)
        {
            var priority = IgnorePriority;
            CodeBuilder<T> result = null;
            foreach (var builder in Builders)
            {
                var builderPriority = builder.GetPriority(value, generation);
                if (builderPriority > priority)
                {
                    priority = builderPriority;
                    result = builder;
                }
            }
            return result;
        }

        public override string Build(T value, CodeGeneration generation)
        {
            var builder = GetBuilder(value, generation);
            if (builder == null)
            {
                return string.Empty;
            }
            else
            {
                return builder.Build(value, generation);
            }
        }

        public override int GetPriority(T value, CodeGeneration generation)
        {
            return GetBuilder(value, generation)?.GetPriority(value, generation) ?? IgnorePriority;
        }
    }
}
