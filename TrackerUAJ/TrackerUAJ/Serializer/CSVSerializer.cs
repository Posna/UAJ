using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerUAJ
{
    class CSVSerializer: ISerializer
    {
        public string Serialize(TrackerEvent e)
        {
            return e.toCSV();
        }
    }
}