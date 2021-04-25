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


        public void trackEvent(TrackerEvent e)
        {
            eventQueue.Enqueue(e);
        }


    }
}
