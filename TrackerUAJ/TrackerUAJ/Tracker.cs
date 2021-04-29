using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerUAJ
{
    public class Tracker
    {
        private Tracker()  { }
        private static Tracker _instance;
        private IPersistence _persistance;

        EventFactory _factory;

        Queue<TrackerEvent> eventQueue;

        // Valores iniciales
        int _idUser;
        public void Init(IPersistence per, int idUser)
        {
            _idUser = idUser;
            _persistance = per;
        }

        public static Tracker GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Tracker();
            }
            return _instance;
        }

        //Ejemplo:
        //_instance.trackEvent(_instance.getEvent("EndGameEvent").SetDamage(2).SetLevel("Nivel 2"));
        public void trackEvent(TrackerEvent e)
        {
            e.date = DateTime.Now;
            eventQueue.Enqueue(e);
        }

        public EndGameEvent getEndGame()
        {
            return (EndGameEvent)_factory.create("EndEvent");
        }

        public CharacterSelectionEvent getCharacterSelectorEvent()
        {
            return (CharacterSelectionEvent)_factory.create("CharacterEvent");
        }


    }
}
