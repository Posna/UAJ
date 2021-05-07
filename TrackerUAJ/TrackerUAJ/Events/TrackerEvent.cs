using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TrackerUAJ
{
    enum TrackEventType{ EndGame, CharacterSelection }

    [Serializable]
    public class TrackerEvent
    {
        /*Atributos*/
        public DateTime date { get; set; }
        public int idUser { get; set; }


        // Mete en CSV las variables comunes
        public virtual string toCSV() { return null; }
        public virtual string toJson() { return null ; }
    }
}