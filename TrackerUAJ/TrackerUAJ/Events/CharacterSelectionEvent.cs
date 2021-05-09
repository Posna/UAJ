﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ServiceStack.Text;

namespace TrackerUAJ
{
    public class CharacterSelectionEvent: TrackerEvent
    {
        public string _name;

        public override string toCSV(){ return CsvSerializer.SerializeToCsv(new[] { this }); }
        public override string toJson() { return JsonConvert.SerializeObject(this); }

        public CharacterSelectionEvent SetCharacterSelected(string name)
        {
            _name = name;
            return this;
        }
    }
}
