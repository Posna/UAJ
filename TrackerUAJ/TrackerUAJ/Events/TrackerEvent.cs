using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerUAJ
{
    [Serializable]
    public class TrackerEvent
    {
        /*Atributos*/

        public DateTime date { get; set; }
        public int idGame { get; set; }
        public int idSession { get; set; }
        public int idUser { get; set; }

        public virtual string toCSV() { return null; }
        public virtual string toJson() { return null; }
    }
}
