using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerUAJ
{
    public class TextPersistance : IPersistence
    {
        string _fileName;
        ISerializer _serializer;
        

        //Nombre del archivo en la contructora
        public TextPersistance(string fileName)
        {
            _fileName = fileName;
        }

        
        public void SetSerializer(ISerializer serializer)
        {
            _serializer = serializer;
        }

        public void Flush()
        {
            //Mandar de la cola todos los eventos
            foreach(TrackerEvent e in Tracker.GetInstance().eventQueue)
            {
                Send(e);
            }

            Tracker.GetInstance().eventQueue.Clear();
        }

        //Enviaria un solo evento que entra como parametro
        public void Send(TrackerEvent e)
        {
            
            StreamWriter writer;
            writer = new StreamWriter(_fileName, File.Exists(_fileName));
            writer.WriteLine(_serializer.Serialize(e));
            writer.Close();
        }
    }
}
