using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Text.Json.Serialization;

namespace TrackerUAJ
{
    [Serializable]
    public class TrackerEvent
    {
        /*Atributos*/

        public DateTime date { get; set; }
        protected int idUser { get; set; }


        // Mete en CSV las variables comunes
        public virtual string toCSV() { return null; }
        public virtual string toJson() { return null ; }
    }
}
