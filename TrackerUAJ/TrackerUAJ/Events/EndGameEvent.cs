using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerUAJ
{
    public class EndGameEvent : TrackerEvent
    {
        int dmg { get; set; }
        public override string toCSV() { return null; }
        public override string toJson() { return null; }
    }
}
