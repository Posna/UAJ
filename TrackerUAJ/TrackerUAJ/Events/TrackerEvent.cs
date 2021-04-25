using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Text.Json.Serialization;

namespace TrackerUAJ
{
    [Serializable]
    public class TrackerEvent: IEndGameEvent, IEvent2
    {
        /*Atributos*/

        public DateTime date { get; set; }
        public int idGame { get; set; }
        public int idSession { get; set; }
        public int idUser { get; set; }

        protected int dmg_;
        protected string level_;


        public virtual string toCSV() { return null; }
        public virtual string toJson() { return null ; }

        
        public TrackerEvent SetDamage(int dmg)
        {
            dmg_ = dmg;
            return this;
        }

        public TrackerEvent SetLevel(string level)
        {
            level_ = level;
            return this;
        }
    }
}
