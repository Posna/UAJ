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
        private List<IPersistence> _persistance;

        EventFactory _factory;
        SerializeFactory _serializeFactory;

        public Queue<TrackerEvent> eventQueue { get; set; }

        // Valores iniciales
        int _idUser;

        
        public void Init(int idUser)
        {
            _idUser = idUser;
            _serializeFactory = new SerializeFactory();
            _factory = new EventFactory();
            eventQueue = new Queue<TrackerEvent>();
            _persistance = new List<IPersistence>();
        }

        public void AddPersistance(IPersistence per, TraceFormats format)
        {
            per.SetSerializer(_serializeFactory.create(format));
            _persistance.Add(per);
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
            e.date = DateTime.Now;
            e.idUser = _idUser;
            foreach (var item in _persistance)
            {
                item.Send(e);
            }
        }

        public void TrackEvent(TrackerEvent e)
        {
            e.date = DateTime.Now;
            e.idUser = _idUser;
            eventQueue.Enqueue(e);
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


    }
}
