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
        List<Category> _categories { get; set; }

        public Cv(int id, Persona persona, List<Category> categories)
        {
            this._id = id;
            this._persona = persona;
            this._categories = categories;
        }

        
    }
}
