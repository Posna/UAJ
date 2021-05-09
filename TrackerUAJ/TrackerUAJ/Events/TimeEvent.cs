using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ServiceStack.Text;

namespace TrackerUAJ
{
    public class TimeEvent : TrackerEvent
    {
        public string _eventName;
        public override string toCSV() { return CsvSerializer.SerializeToCsv(new[] { this }); }
        public override string toJson() { return JsonConvert.SerializeObject(this); }

        public TimeEvent SetEventName(string name)
        {
            _eventName = name;
            return this;
        }
    }
}
