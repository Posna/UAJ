using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerUAJ
{
    public interface IPersistence
    {
        IPersistence (ISerializer s)
        {
            serializer = s;
        }
        ISerializer serializer;
        public virtual void Send();
        public virtual void Flush();
    }
}
