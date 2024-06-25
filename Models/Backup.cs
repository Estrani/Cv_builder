using ConsoleApp2.Models;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace PublipostageDemo.Models
{
    internal class Backup
    {
        [JsonInclude]
        int _id {  get; set; }
        [JsonInclude]
        Engine _engine { get; set; }

        public Backup () { }
        public Backup(int id, Engine engine)
        {
            this._id = id;
            this._engine = engine;
        }

        public int GetId() {  return _id; }
        public Engine GetEngine() { return _engine; }

        public void SetId(int id) { this._id = id;}
        public void SetEngine(Engine engine) { this._engine = engine;}


        public void ToJsonFile()
        {
            string folderPath = "../Backup";

            var engine = this.GetEngine();
            if (engine == null)
            {
                throw new Exception("GetEngine() a retourné null.");
            }

            var cv = engine.GetCv();
            if (cv == null)
            {
                throw new Exception("GetCv() a retourné null.");
            }

            var persona = cv.GetPersona();
            if (persona == null)
            {
                throw new Exception("GetPersona() a retourné null.");
            }

            var title = persona.GetTitle();
            if (string.IsNullOrEmpty(title))
            {
                throw new Exception("GetTitle() a retourné une valeur nulle ou vide.");
            }

            string fileName = title + ".json";

            //string fileName = string.Join(this.GetEngine().GetCv().GetPersona().GetTitle(),".json");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string filePath = Path.Combine(folderPath, fileName);

            Console.WriteLine($"Titre: {title}");
            Console.WriteLine($"Objet Engine: {JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true })}");


            string jsonString = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(filePath, jsonString);
        }

        public void ReadJsonFile(string fileName)
        {
            string jsonStringFromFile = File.ReadAllText(fileName);

            Backup deserializedFile = JsonSerializer.Deserialize<Backup>(jsonStringFromFile);

            this.SetId(deserializedFile._id);
            this.SetEngine(deserializedFile._engine);
        }
    }
}
