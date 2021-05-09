using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ServiceStack.Text;

namespace TrackerUAJ
{
    public class EndSessionEvent:TrackerEvent
    {
        public DateTime _sessionStart;
        public override string toCSV() { return CsvSerializer.SerializeToCsv(new[] { this }); }
        public override string toJson() { return JsonConvert.SerializeObject(this); }

        public EndSessionEvent()
        {
            _sessionStart = DateTime.Now;
        }
    }
}
