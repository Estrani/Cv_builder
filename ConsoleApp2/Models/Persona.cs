using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class Persona
    {
        int _id { get; set; }
        string _name { get; set; }
        string _title { get; set; }
        string _picture {  get; set; }
        string _city { get; set; }
        string _email {  get; set; }
        string _phone { get; set; }
        List<Misc>_miscs { get; set; }

        public Persona(int id, string name, string title, string picture, string city, string email, string phone, List<Misc> miscs)
        {
            _id = id;
            _name = name;
            _title = title;
            _picture = picture;
            _city = city;
            _email = email;
            _phone = phone;
            _miscs = miscs;
        }

        public string GetPersona()
        {
            return (this._id + this._name + this._title + this._picture + this._city + this._email + this._phone + this._miscs).ToString();
        }

        public List<Misc> GetMiscs()
        {
            return this._miscs;
            
        }

        public void AddMisc(int a, string b)
        {
           Misc new_misc = new Misc(a, b);
           this._miscs.Add(new_misc);
        }

        public Misc GetMiscById(int a) 
        {
            return this.GetMiscs().FirstOrDefault(misc => misc.GetId() == a);
        }

        public void UpdateExtraMisc(int a, string b)
        {
            this.GetMiscById(a).SetExtra(b);

        }

        public void RemoveMisc(int a) 
        {
            this.GetMiscs().Remove(this.GetMiscById(a));
        }
    }
}
