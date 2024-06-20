using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class CategoryCv
    {
        int _id {  get; set; }
        string _title { get; set; }
        string _icon { get; set; }
        List<Info> _infos { get; set; }
        List<Work> _works { get; set; }

        public CategoryCv(int id, string title, string icon, List<Info> infos)
        {
            this._id = id;
            this._title = title;
            this._icon = icon;
            this._infos = infos;
        }

        public CategoryCv(int id, string title, string icon, List<Work> works)
        {
            this._id = id;
            this._title = title;
            this._icon = icon;
            this._works = works;
        }

        public int GetId() { return _id; }
        public string GetTitle() { return _title; }
        public string GetIcon() { return _icon;}

        public string GetCategory()
        {
            return (this._id + this._title + this._icon + this._infos + this._works).ToString();
        }


        public List<Info> GetInfos(){ return this._infos; }

        public void AddInfo(int a, string b)
        {
            Info new_info = new Info(a, b);
            this._infos.Add(new_info);
        }

        public Info GetInfoById(int a){ return this.GetInfos().FirstOrDefault(info => info.GetId() == a); }

        public void UpdateNameInfo(int a, string b){ this.GetInfoById(a).SetName(b); }

        public void RemoveInfo(int a){ this.GetInfos().Remove(this.GetInfoById(a)); }


        public List<Work> GetWorks() { return this._works; }

        public void AddWork(int a, int b, string c, string d, string e, string f, List<Info> g, string h)
        {
            Work new_work = new Work(a, b, c, d, e, f, g, h);
            this._works.Add(new_work);
        }

        public Work GetWorkById(int a) { return this.GetWorks().FirstOrDefault(work => work.GetId() == a); }

        public void UpdateWorkContent(int a, int b, string c, string d, string e, string f, List<Info> g, string h) 
        { this.GetWorkById(a).SetWorkContent(b, c, d, e, f, g, h); }

        public void RemoveWork(int a) { this.GetWorks().Remove(this.GetWorkById(a)); }
    }
}
