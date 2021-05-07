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
                case TrackEventType.CharacterSelection:
                    return new JSONSerializer();
                case TraceFormats.JSON:
                default:
                    return new JSONSerializer();

            }
        }
    }
}
