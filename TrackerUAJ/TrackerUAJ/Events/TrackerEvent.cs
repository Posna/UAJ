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


        // Mete en CSV las variables comunes
        public virtual string toCSV() { return null; }
        public virtual string toJson() { return null ; }
    }
}