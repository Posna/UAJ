using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerUAJ
{
    //Sin implementar en los eventos
    class CSVSerializer: ISerializer
    {
        public string Serialize(TrackerEvent e)
        {
            return e.toCSV();
        }
    }
}