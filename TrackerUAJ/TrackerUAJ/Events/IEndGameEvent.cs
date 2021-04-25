using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerUAJ
{
    public interface IEndGameEvent
    {
        TrackerEvent SetDamage(int dmg);
    }
}
