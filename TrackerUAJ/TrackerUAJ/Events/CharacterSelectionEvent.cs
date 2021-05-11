using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;
using ServiceStack.Text;

namespace TrackerUAJ
{
    public class CharacterSelectionEvent : TrackerEvent
    {
        public string _name;

        public override string toJson() { return JsonConvert.SerializeObject(this); }
        public override string toCSV() { return null; }
        public override string toXML()
        {
            using (var stringwriter = new StringWriter())
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(this.GetType());
                serializer.Serialize(stringwriter, this);
                return stringwriter.ToString();
            }
        }

        public CharacterSelectionEvent SetCharacterSelected(string name)
        {
            _name = name;
            return this;
        }
    }
}
