﻿using ConsoleApp2.Models;
using Microsoft.Office.Interop.Word;
using PublipostageDemo.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using Word = Microsoft.Office.Interop.Word;

namespace PublipostageDemo
{
    public partial class Form1 : Form
    {
        private MsDocumentHelper closeAllOpendApps;
        public Form1()
        {
            InitializeComponent();
            closeAllOpendApps = new MsDocumentHelper();
            closeAllOpendApps.Close("Opening");
            this.Closing += Form1_Closing;
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (null == closeAllOpendApps)
                closeAllOpendApps = new MsDocumentHelper();
            closeAllOpendApps.Close("Closing");
        }

        private void generate_Click(object sender, EventArgs e)
        {
            // A ne pas oublier : 
            // Clic droit sur votre projet -> Ajouter -> Références. 
            // Sélectionner l'onglet Com
            // Dans la barre de recherche en haut a droite, taper Word
            // Sélectionner Microsoft Word 16.0 Object Library

            // Pour vos templates Word: Simple clic sur le nom du fichier dans l'explorateur de solution 
            // Dans la fenêtre de propriétés en dessous sélectionner "Toujours copier" pour la ligne "Copier dans le répertoire de sortie"



            // Si jamais vous rencontrez cette erreur : warning MSB3026: Impossible de copier
            // Ouvrez le gestionnaire des taches, cherchez tous les programmes word ouvert et faites "fin de tache"


            // Chemin complet: Récupère le dossier courant dans lequel votre application est exécutée (en debug le dossier bin/Debug). 
            // Par exemple si mon projet se trouve dans C:\Users\monUser\PublipostageDemo
            // Mon dossier bin/Debug sera C:\Users\monUser\PublipostageDemo\bin\Debug 
            // Mon fichier wordTemplate.docx sera C:\Users\monUser\PublipostageDemo\bin\Debug\Template\wordTemplate.xlsx
            string cheminTemplate = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Template/wordTemplate.docx");
            string fichierFinal = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"document.pdf");

            Dictionary<string, string> elements = new Dictionary<string, string>();


            elements.Add("Prenom", firstname.Text);
            elements.Add("NomDeFamille", lastname.Text);

            // Ouverture du fichier word
            Word.Application wApp = new Word.Application();
            Word.Document document = wApp.Documents.Open(cheminTemplate, ReadOnly: true);


            #region Remplacer les champ du fichier word par des valeurs
            // Pour chaque champ dans le fichier word
            foreach (Word.Field myMergeField in document.Fields)
            {
                Word.Range rngFieldCode = myMergeField.Code;
                String fieldText = rngFieldCode.Text;
                string mergeSelector = " MERGEFIELD";
                // Si le champ commence par " MERGEFIELD"
                if (fieldText.StartsWith(mergeSelector))
                {
                    // Pour chaque élément de notre dictionaire 
                    foreach (KeyValuePair<string, string> item in elements)
                    {
                        // On regarde si la clé de l'élément courant du dictionaire
                        // Est contenue dans le nom du champ $
                        // Par exemple pour le champ Prenom que l'on a dans le fichier word, 
                        // Son nom complet est " MERGEFIELD  Prenom  \\* MERGEFORMAT "
                        if (fieldText.Contains(item.Key))
                        {
                            // SI c'est le cas, on sélectionne ce champ 
                            myMergeField.Select();
                            // On modifie sa valeur
                            wApp.Selection.TypeText(item.Value);
                            break;
                        }
                    }
                }
            }
            Misc permis = new Misc(1, "PermisB");
            Misc langue = new Misc(2, "Anglais");

            #endregion
            List<Misc> miscs = new List<Misc>() { permis, langue };

            Persona persona1 = new Persona(1, "Lambert Perrine", "Développeuse C#", "img", "Graveson", "perrine.lambert24@gmail.com", "0606060606", miscs);

            #region ajouter un tableau
            // Get the collection of all tables in the document
            Word.Tables allTablesInDocument = document.Tables;

            List<Table> allTables = new List<Table>();
            // Iterate through each table and add it to the list
            foreach (Word.Table table in allTablesInDocument)
            {
                allTables.Add(table);
            }
            //persona tabs
            Table ppTable = allTables.Where(x => x.Title == "pp_tab").First();
            if (ppTable != null)
            {
                Word.Cell ppCell = ppTable.Cell(1, 1);
                ppCell.Range.Text = persona1.GetPicture().ToString();
            }

            Table titleTable = allTables.Where(x => x.Title == "title_tab").First();
            if (titleTable != null)
            {
                Word.Cell titleCell = titleTable.Cell(1, 1);
                titleCell.Range.Text = persona1.GetTitle().ToString();
            }

            Table personaTable = allTables.Where(x => x.Title == "persona_tab").First();
            if (personaTable != null)
            {
                Word.Cell personaCell = personaTable.Cell(1, 1);
                personaCell.Range.Text = string.Join("\r\n", persona1.GetName(), persona1.GetCity(), persona1.GetEmail(), persona1.GetPhone());
            }

            Table miscTable = allTables.Where(x => x.Title == "misc_tab").First();
            if (miscTable != null)
            {
                Word.Cell miscCell = miscTable.Cell(1, 1);
                miscCell.Range.Text = string.Join("\r\n", persona1.GetMiscs().Select(x => x.GetExtra()));
            }

            // Category tabs


            // Work work = new Work(1, 2024, "formation", "Arles", "Greta", "certif", l_infos, ".............................");
            //  List<Work> listW = new List<Work>() { work };

            //  List<CategoryCv> cater = new List<CategoryCv>() { cat };
            // Cv cv = new Cv(1, personne, cater);

            Info calme = new Info(2, "Calme");
            List<Info> soft = new List<Info>() { calme };
            CategoryCv savoir_etre = new CategoryCv(2, "Savoir-être", "-o-", soft);


            Table softskillTable = allTables.Where(x => x.Title == "softskill_tab").First();
            if (softskillTable != null)
            {
                Word.Cell softskillCell = softskillTable.Cell(1, 1);
                softskillCell.Range.Text = string.Join(" ", savoir_etre.GetIcon(), savoir_etre.GetTitle());

                Word.Cell softskillCell2 = softskillTable.Cell(2, 1);
                softskillCell2.Range.Text = string.Join("\r\n", savoir_etre.GetInfos().Select(x => x.GetName()));
            }

            Info loisir = new Info(1, "Jeu vidéo");
            List<Info> l_infos = new List<Info>() { loisir };
            CategoryCv cat = new CategoryCv(1, "Centre d'interets", "lllllll", l_infos);


            Table hobbyTable = allTables.Where(x => x.Title == "hobby_tab").First();
            if (hobbyTable != null)
            {
                Word.Cell hobbyCell = hobbyTable.Cell(1, 1);
                hobbyCell.Range.Text = string.Join(" ", cat.GetIcon(), cat.GetTitle());

                Word.Cell hobbyCell2 = hobbyTable.Cell(2, 1);
                hobbyCell2.Range.Text = string.Join("\r\n", cat.GetInfos().Select(x => x.GetName()));
            }

            Info git = new Info(3, "Github link");
            List<Info> social_net = new List<Info>() { git };
            CategoryCv reseaux_sociaux = new CategoryCv(3, "Réseaux sociaux", "o-o-o", social_net);


            Table socialTable = allTables.Where(x => x.Title == "social_tab").First();
            if (socialTable != null)
            {
                Word.Cell socialCell = socialTable.Cell(1, 1);
                socialCell.Range.Text = string.Join(" ", reseaux_sociaux.GetIcon(), reseaux_sociaux.GetTitle());

                Word.Cell socialCell2 = socialTable.Cell(2, 1);
                socialCell2.Range.Text = string.Join("\r\n", reseaux_sociaux.GetInfos().Select(x => x.GetName()));
            }

            Info html = new Info(4, "HTML5");
            List<Info> savoir = new List<Info>() { html };
            CategoryCv savoir_faire = new CategoryCv(4, "Savoir-faire", "lo/", savoir);

            Info figma = new Info(6, "Figma");
            List<Info> outil = new List<Info>() { figma };
            CategoryCv tools = new CategoryCv(5, "Outils Maitrisés", "/lo", outil);

            Table skillTable = allTables.Where(x => x.Title == "skill_tab").First();
            if (skillTable != null)
            {
                Word.Cell skillCell = skillTable.Cell(1, 1);
                skillCell.Range.Text = string.Join(" ", savoir_faire.GetIcon(), savoir_faire.GetTitle());

                Word.Cell skillCell2 = skillTable.Cell(2, 1);
                skillCell2.Range.Text = string.Join("\r\n", savoir_faire.GetInfos().Select(x => x.GetName()));

                Word.Cell skillCell3 = skillTable.Cell(1, 2);
                skillCell3.Range.Text = string.Join(" ", tools.GetIcon(), tools.GetTitle());

                Word.Cell skillCell4 = skillTable.Cell(2, 2);
                skillCell4.Range.Text = string.Join("\r\n", tools.GetInfos().Select(x => x.GetName()));
            }

            #endregion

            document.ExportAsFixedFormat(fichierFinal, Word.WdExportFormat.wdExportFormatPDF);

            // Evite d'enregistrer le fichier template avec les valeurs renseignées. 
            // Si non le fichier n'est plus utilisable
            wApp.Quit(SaveChanges: false);
        }

        
    }
}
