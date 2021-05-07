using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerUAJ
{
    public class CharacterSelectionEvent: TrackerEvent
    {
        public string name_;

        public override string toCSV()
        {
            int a = 0;
            a += 1;
            return null;
        }
        public override string toJson() { return null; }

        public CharacterSelectionEvent SetCharacterSelected(string name)
        {
            name_ = name;
            return this;
        }
    }
}
