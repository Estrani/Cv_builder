using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class Category
    {
        int _id {  get; set; }
        string _title { get; set; }
        string _icon { get; set; }
        List<Info> _infos { get; set; }
        List<Work> _works { get; set; }

        public Category(int id, string title, string icon, List<Info> infos, List<Work> works)
        {
            this._id = id;
            this._title = title;
            this._icon = icon;
            this._infos = infos;
            this._works = works;
        }

        public string GetCategory()
        {
            return (this._id + this._title + this._icon + this._infos + this._works).ToString();
        }
    }
}
