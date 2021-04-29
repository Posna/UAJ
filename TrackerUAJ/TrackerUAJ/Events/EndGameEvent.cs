using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerUAJ
{
    public class EndGameEvent : TrackerEvent
    {
        int _dmg;
        int _idGame;
        public override string toCSV() {
            int a = 0;
            a += 3;
            return null;
        }
        public override string toJson() { return null; }

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
