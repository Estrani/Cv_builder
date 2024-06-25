﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class Misc
    {
        [JsonInclude]
        int _id {  get; set; }
        [JsonInclude]
        string _extra { get; set; }

        public Misc() { }

        public Misc(int id, string extra)
        {
            this._id = id;
            this._extra = extra;
        }

        public void SetExtra(string extra) { this._extra = extra; }
        public int GetId() { return _id; }
        public string GetExtra() { return _extra; }
    }
}
