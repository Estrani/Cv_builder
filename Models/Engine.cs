using ConsoleApp2.Models;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PublipostageDemo.Models
{
    internal class Engine
    {
        [JsonInclude]
        int _id {  get; set; }
        [JsonInclude]
        Cv _cv { get; set; }
        [JsonInclude]
        string _style { get; set; }

        public Engine() { }


        public Engine(int id, Cv cv, string style)
        {
            this._id = id;
            this._cv = cv;
            this._style = style;
        }

        public Cv GetCv() { return this._cv; }
    }
}
