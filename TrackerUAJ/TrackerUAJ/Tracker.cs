using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TrackerUAJ
{
    public class Tracker
    {
        private Tracker()  { }
        private static Tracker _instance;
        private List<IPersistence> _persistance;

        EventFactory _factory;
        SerializeFactory _serializeFactory;

        Queue<TrackerEvent> _eventQueue;

        Thread _thread;
        bool _exit = false;
        float _timeWaiting;

        // Valores iniciales
        int _idUser;

        
        public void Init(int idUser)
        {
            _idUser = idUser;
            _serializeFactory = new SerializeFactory();
            _factory = new EventFactory();
            _eventQueue = new Queue<TrackerEvent>();
            _persistance = new List<IPersistence>();
        }

        public void Init(int idUser, float time)
        {
            Init(idUser);
            ThreadStart threadStart = new ThreadStart(ThreadLoop);
            _timeWaiting = time;
            _thread = new Thread(threadStart);
            _thread.Start();
        }


        public void AddPersistance(IPersistence per, TraceFormats format)
        {
            per.SetSerializer(_serializeFactory.create(format));
            lock (this)
            {
                _persistance.Add(per);
            }
        }

        public static Tracker GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Tracker();
            }
            return _instance;
        }

        public void SendEvent(TrackerEvent e)
        {
            e._date = DateTime.Now;
            e._idUser = _idUser;
            lock (this)
            {
                foreach (var item in _persistance)
                {
                    item.Send(e);
                }
            }
        }

        public void TrackEvent(TrackerEvent e)
        {
            e._date = DateTime.Now;
            e._idUser = _idUser;
            _eventQueue.Enqueue(e);
        }

        private void ThreadLoop()
        {
            while (!_exit)
            {
                lock (this)
                {
                    Flush();
                }
                Thread.Sleep((int)(_timeWaiting*1000.0f));
            }
        }

        public void Flush()
        {
            foreach (var item in _persistance)
            {
                item.Flush();
            }
        }

        //Finalizacion del tracker
        public void End()
        {
            _exit = true;
            _thread.Join();
            Flush();
        }

        public EndGameEvent getEndGame()
        {
            return (EndGameEvent)_factory.create(TrackEventType.EndGame);
        }

        public CharacterSelectionEvent getCharacterSelectorEvent()
        {
            return (CharacterSelectionEvent)_factory.create(TrackEventType.CharacterSelection);
        }

        public Queue<TrackerEvent> GetQueue(){ return _eventQueue; }

    }
}
