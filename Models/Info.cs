using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class Info
    {
        [JsonInclude]
        int _id { get; set; }
        [JsonInclude]
        string _name { get; set; }

        public Info() { }

        public Info(int id, string name)
        {
            this._id = id;
            this._name = name;
        }

        public void SetName(string name) { this._name = name; }
     
        public int GetId() { return _id; }
        public string GetName() { return _name; }
    }
}
