using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesCodeGen.Coding
{
    public class CodeGeneration
    {
        public Mapping Mapping { get; private set; } = new Mapping();
        public Dictionary<string, ProtocolBuilder> ProtocolBuilders { get; private set; } = new Dictionary<string, ProtocolBuilder>();
    }
}
