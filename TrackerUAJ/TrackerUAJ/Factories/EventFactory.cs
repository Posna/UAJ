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
        public TrackerEvent create (string name) 
        {
            switch (name)
            {
                case "EndEvent":
                    return new EndGameEvent();
                case "CharacterEvent":
                    return new CharacterSelectionEvent();
                   
            }

            return new TrackerEvent();
        }
    }
}
