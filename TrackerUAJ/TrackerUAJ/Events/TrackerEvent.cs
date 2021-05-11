using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerUAJ
{
    enum TrackEventType{ EndGame, CharacterSelection, TimeEvent, EndSession }

    [Serializable]
    public class TrackerEvent
    {
        /*Atributos*/
        public DateTime _date { get; set; }
        public int _idUser { get; set; }


        public virtual string toCSV() { return null; }
        public virtual string toJson() { return null ; }
        public virtual string toXML() { return null; }

    }
}