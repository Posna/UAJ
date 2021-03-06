using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TrackerUAJ
{
    public class EventFactory : IFactory<TrackerEvent>
    {
        public TrackerEvent create (Enum name) 
        {
            switch (name)
            {
                case TrackEventType.EndGame:
                    return new EndGameEvent();
                case TrackEventType.CharacterSelection:
                    return new CharacterSelectionEvent();
                case TrackEventType.TimeEvent:
                    return new TimeEvent();
                case TrackEventType.EndSession:
                    return new EndSessionEvent();
            }

            return new TrackerEvent();
        }
    }
}
