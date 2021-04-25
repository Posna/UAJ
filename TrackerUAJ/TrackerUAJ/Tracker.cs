using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerUAJ
{
    public class Tracker
    {
        private Tracker() { }
        private static Tracker _instance;
        private IPersistence _persistance;

        EventFactory _factory;

        Queue<TrackerEvent> eventQueue;
        public void Init(IPersistence per)
        {
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
            eventQueue.Enqueue(e);
        }

        public TrackerEvent getEvent(string nameEvent)
        {
            switch (nameEvent)
            {
                case "EndGameEvent":
                    return new EndGameEvent();
                case "Event2":
                    return new Event2();
                default:
                    return new TrackerEvent();                    
            }
        }

        public EndGameEvent getEndGame()
        {
            return (EndGameEvent)_factory.create("end");
        }


    }
}
