using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class Persona
    {
        [JsonInclude]
        int _id { get; set; }
        [JsonInclude]
        string _name { get; set; }
        [JsonInclude]
        string _title { get; set; }
        [JsonInclude]
        string _picture {  get; set; }
        [JsonInclude]
        string _city { get; set; }
        [JsonInclude]
        string _email {  get; set; }
        [JsonInclude]
        string _phone { get; set; }
        [JsonInclude]
        List<Misc>_miscs { get; set; }

        public Persona() { }

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
            return (this._id + "\r\n" + this._name + "\r\n" + this._title + "\r\n" + this._picture + "\r\n" + this._city + "\r\n" + this._email + "\r\n" + this._phone + "\r\n" + this._miscs).ToString();
        }

        public string GetName() { return this._name; }
        public string GetTitle() { return this._title; }
        public string GetPicture() { return this._picture; }
        public string GetCity() { return this._city; }
        public string GetEmail() { return this._email; }
        public string GetPhone() { return this._phone; }

        public List<Misc> GetMiscs(){ return this._miscs; }

        public void AddMisc(int a, string b)
        {
           Misc new_misc = new Misc(a, b);
           this._miscs.Add(new_misc);
        }

        public Misc GetMiscById(int a){ return this.GetMiscs().FirstOrDefault(misc => misc.GetId() == a); }

        public void UpdateExtraMisc(int a, string b){ this.GetMiscById(a).SetExtra(b); }

        public void RemoveMisc(int a){ this.GetMiscs().Remove(this.GetMiscById(a)); }
    }
}
