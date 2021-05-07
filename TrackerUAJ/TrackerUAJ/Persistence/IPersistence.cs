using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerUAJ
{
    enum PersistanceType { Disk, Server }
    public interface IPersistence
    {
        void SetSerializer(ISerializer serializer);
        void Send(TrackerEvent e);
        void Flush();
    }
}
