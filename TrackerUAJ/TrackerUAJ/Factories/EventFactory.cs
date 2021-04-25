using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerUAJ
{
    public class EventFactory : IFactory<TrackerEvent>
    {
        public TrackerEvent create (string name) 
        {
            switch (name)
            {
                case "end":
                    break;
            }

            return new TrackerEvent();
        }
    }
}
