using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Misc permis = new Misc(1, "permisB");
            Console.WriteLine(permis.GetId());
            Console.WriteLine(permis.GetExtra());

            List<Misc> list = new List<Misc>() {permis};
            Persona personne = new Persona(1, "nom", "titre", "C:", "ville", "email@email.com", "0660606060", list);
            Console.WriteLine(personne.GetPersona());
            Console.WriteLine(personne.GetMiscs());


            personne.AddMisc(2, "SST");
            Console.WriteLine(personne.GetMiscById(2).GetExtra());
            personne.UpdateExtraMisc(2, "Anglais");
            Console.WriteLine(personne.GetMiscById(2).GetExtra());


            personne.RemoveMisc(2);



            Info loisir = new Info(1, "Jeu vidéo");
            Console.WriteLine(loisir.GetId());
            Console.WriteLine(loisir.GetName());

            List<Info> h = new List<Info>() { loisir };
            Work work = new Work(1, 2024, "formation", "Arles", "Greta", "certif", h, ".............................");
            Console.WriteLine(work.GetWork());

            List<Work> listW = new List<Work>() { work };
            Category cat = new Category(1, "Outils", "dddd", h, listW);
            Console.WriteLine(cat.GetCategory());

            List<Category>cater = new List<Category>() { cat };
            Cv cv = new Cv(1, personne, cater);

            Console.ReadLine();
        }
    }
}
