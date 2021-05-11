using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerUAJ
{
    class SerializeFactory: IFactory<ISerializer>
    {
        public ISerializer create(Enum name)
        {
            switch (name)
            {
                case TraceFormats.CSV:
                    return new CSVSerializer();
                case TraceFormats.XML:
                    return new XMLSerializer();
                case TraceFormats.JSON:
                default:
                    return new JSONSerializer();

            }
        }
    }
}
