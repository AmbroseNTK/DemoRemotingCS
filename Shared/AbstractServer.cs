using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;

namespace Shared
{
    public abstract class AbstractServer : MarshalByRefObject
    {
        public virtual List<Note> GetNote() => null;
    }
}
