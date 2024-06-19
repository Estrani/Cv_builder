using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class Cv
    {
        int _id {  get; set; }
        Persona _persona { get; set; }
        List<CategoryCv> _categories { get; set; }

        public Cv(int id, Persona persona, List<CategoryCv> categories)
        {
            this._id = id;
            this._persona = persona;
            this._categories = categories;
        }

        public List<CategoryCv> GetCategories() { return this._categories; }

        public void SetPersona(int id, string name, string title, string picture, string city, string email, string phone, List<Misc> miscs)
        {
            Persona new_persona = new Persona(id, name, title, picture, city, email, phone, miscs);
                this._persona = new_persona;
        }

        public void AddCategory(int id, string title, string icon, List<Info> infos, List<Work> works)
        {
            CategoryCv new_category = new CategoryCv(id, title, icon, infos, works);
            this._categories.Add(new_category);
        }

        public CategoryCv GetCategoryById(int a) { return this.GetCategories().FirstOrDefault(category => category.GetId() == a); }

       // public void UpdateCategory(int a, string b) { this.GetMiscById(a).SetExtra(b); }

        public void RemoveCategory(int a) { this.GetCategories().Remove(this.GetCategoryById(a)); }
    }
}
