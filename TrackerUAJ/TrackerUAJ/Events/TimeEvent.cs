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
        public override string toJson() { return JsonConvert.SerializeObject(this); }
        public override string toCSV() { return null; }
        public override string toXML()
        {
            using (var stringwriter = new System.IO.StringWriter())
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(this.GetType());
                serializer.Serialize(stringwriter, this);
                return stringwriter.ToString();
            }
        }

        public TimeEvent SetEventName(string name)
        {
            _eventName = name;
            return this;
        }
    }
}
