using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace TrackerUAJ
{
    public class ServerPersistance : IPersistence
    {
        string _url;
        ISerializer _serializer;

        public ServerPersistance(string url)
        {
            _url = url;
        }

        public void Flush()
        {
            //Mandar de la cola todos los eventos
            foreach (TrackerEvent e in Tracker.GetInstance().GetQueue())
            {
                Send(e);
            }

            Tracker.GetInstance().GetQueue().Clear();
        }

        public void Send(TrackerEvent e)
        {
            Post(_serializer.Serialize(e), _url);
        }

        public void SetSerializer(ISerializer serializer)
        {
            _serializer = serializer;
        }

        private string Post(string json, string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "text/plain";
            request.Accept = "text/plain";

            try
            {
                using (StreamWriter streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }
            catch (SocketException ex)
            {
                return ex.Message;
            }

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return "";
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            return responseBody;
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                using (WebResponse response = ex.Response)
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return "";
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            return responseBody;
                        }
                    }
                }
            }
            catch (SocketException e)
            {
                return e.Message;
            }
        }
    }
}
