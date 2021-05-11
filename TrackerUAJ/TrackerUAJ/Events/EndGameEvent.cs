using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ServiceStack.Text;

namespace TrackerUAJ
{
    [Serializable]
    public class EndGameEvent : TrackerEvent
    {
        [Serializable]
        public struct Round
        {
            public float _timeRound;
            public float _resulRound;
        }

        public int _idGame;
        public int _shots;
        public float _dmg;
        public float _totalGameTime;
        public string _player;
        public string _rival;
        public Round[] _rounds;

        public EndGameEvent()
        {
            _rounds = new Round[3];
        }

        public override string toJson(){ return JsonConvert.SerializeObject(this); }
        public override string toCSV() { return null; }
        public override string toXML()
        {
            using (var stringwriter = new System.IO.StringWriter())
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(this.GetType());
                serializer.Serialize(stringwriter, this);
                return stringwriter.ToString();
            }
        }


        public EndGameEvent SetIdGame(int idGame)
        {
            _idGame = idGame;
            return this;
        }

        public EndGameEvent SetShots(int shots)
        {
            _shots = shots;
            return this;
        }
        public EndGameEvent SetDamage(float dmg)
        {
            _dmg = dmg;
            return this;
        }

        public EndGameEvent SetTotalGameTime(float time)
        {
            _totalGameTime = time;
            return this;
        }

        public EndGameEvent SetPlayerName(string player)
        {
            _player = player;
            return this;
        }
        public EndGameEvent SetRivalName(string rival)
        {
            _rival = rival;
            return this;
        }

        public EndGameEvent SetTimeRound(float timeRound, int round)
        {
            _rounds[round]._timeRound = timeRound;
            return this;
        }

        public EndGameEvent SetResultRound(float resultRound, int round)
        {
            _rounds[round]._resulRound = resultRound;
            return this;
        }
    }
    
}
