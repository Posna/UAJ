using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerUAJ
{
    public class TrackerEvent
    {
        /*Atributos*/
        DateTime date;
        int idGame;
        int idSession;
        int idUser;
        public virtual string toCSV() {return null; }
        public virtual string toJson() { return null; }
    }
}
