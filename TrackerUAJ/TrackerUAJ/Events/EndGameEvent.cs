using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TrackerUAJ
{
    [Serializable]
    public class EndGameEvent : TrackerEvent
    {
        public int _dmg;
        public int _idGame;
        public override string toCSV() {
            int a = 0;
            a += 3;
            return null;
        }
        public override string toJson()
        {            
            return JsonConvert.SerializeObject(this);
        }

        public EndGameEvent SetDamage(int dmg)
        {
            _dmg = dmg;
            return this;
        }
        
        public EndGameEvent SetIdGame(int idGame)
        {
            _idGame = idGame;
            return this;
        }
    }
}
