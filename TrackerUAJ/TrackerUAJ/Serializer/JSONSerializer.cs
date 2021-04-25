using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerUAJ.Serializer
{
    class JSONSerializer : ISerializer
    {
        public string Serialize(TrackerEvent e)
        {
            return e.toJson();
        }
    }
}
