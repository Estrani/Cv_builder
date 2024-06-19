using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class Work
    {
        int _id {  get; set; }
        int _year {  get; set; }
        string _title { get; set; }
        string _place { get; set; }
        string _organism { get; set; }
        string _certificate {  get; set; }
        List<Info> _skills { get; set; }
        string _description { get; set; }

        public Work (int id, int year, string title, string place, string organism, string certificate, List<Info> skills, string description)
        {
            this._id = id;
            this._year = year;
            this._title = title;
            this._place = place;
            this._organism = organism;
            this._certificate = certificate;
            this._skills = skills;
            this._description = description;
        }

        public void SetWorkContent(int b, string c, string d, string e, string f, List<Info> g, string h)
        {
            this._year = b;
            this._title = c;
            this._place = d;
            this._organism = e;
            this._certificate = f;
            this._skills = g;
            this._description = h;

        }
        public int GetId() { return _id; }

        public string GetWork()
        {
            return (this._id + this._year + this._title + this._place + this._organism + this._certificate + this._skills + this._description).ToString();
        }


        public List<Info> GetSkills()
        {
            return this._skills;

        }

        public void AddSkill(int a, string b)
        {
            Info new_info = new Info(a, b);
            this._skills.Add(new_info);
        }

        public Info GetInfoById(int a)
        {
            return this.GetSkills().FirstOrDefault(info => info.GetId() == a);
        }

        public void UpdateNameInfo(int a, string b)
        {
            this.GetInfoById(a).SetName(b);

        }

        public void RemoveInfo(int a)
        {
            this.GetSkills().Remove(this.GetInfoById(a));
        }
    }
}
