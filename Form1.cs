using ConsoleApp2.Models;
using Microsoft.Office.Interop.Word;
using PublipostageDemo.Helper;
using PublipostageDemo.Models;
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
        int rowdf = 1;
        int rowep = 1;
        int rowMisc = 1;
        int rowse = 1;
        int rowci = 1;
        int rowrs = 1;
        int rowum = 1;
        int rowsf = 1;


        private System.Windows.Forms.TableLayoutPanel PersonaPanel;
        private System.Windows.Forms.TextBox TitleInput;
        private System.Windows.Forms.PictureBox ppPicture;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox CityInput;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.TextBox PhoneInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        




        private MsDocumentHelper closeAllOpendApps;
        public Form1()
        {
            InitializeComponent();
            InitCv();
            closeAllOpendApps = new MsDocumentHelper();
            closeAllOpendApps.Close("Opening");
            this.Closing += Form1_Closing;
        }

        private void InitCv()
        {
            this.PersonaPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ppPicture = new System.Windows.Forms.PictureBox();
            this.TitleInput = new System.Windows.Forms.TextBox();
            this.CityInput = new System.Windows.Forms.TextBox();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.PhoneInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();

            this.PersonaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppPicture)).BeginInit();

            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2.SuspendLayout();



            // 
            // PersonaPanel
            // 
            this.PersonaPanel.ColumnCount = 3;
            this.PersonaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.46409F));
            this.PersonaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.53591F));
            this.PersonaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 518F));
            this.PersonaPanel.Controls.Add(this.ppPicture, 1, 0);
            this.PersonaPanel.Controls.Add(this.TitleInput, 2, 0);
            this.PersonaPanel.Controls.Add(this.CityInput, 2, 2);
            this.PersonaPanel.Controls.Add(this.EmailInput, 2, 3);
            this.PersonaPanel.Controls.Add(this.PhoneInput, 2, 4);
            this.PersonaPanel.Controls.Add(this.label4, 0, 0);
            this.PersonaPanel.Controls.Add(this.NameInput, 2, 1);
            this.PersonaPanel.Location = new System.Drawing.Point(3, 3);
            this.PersonaPanel.Name = "PersonaPanel";
            this.PersonaPanel.RowCount = 5;
            this.PersonaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PersonaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PersonaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PersonaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.PersonaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.PersonaPanel.Size = new System.Drawing.Size(731, 160);
            this.PersonaPanel.TabIndex = 2;

            // 
            // ppPicture
            // 
            this.ppPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ppPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.ppPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ppPicture.Location = new System.Drawing.Point(80, 3);
            this.ppPicture.Name = "ppPicture";
            this.PersonaPanel.SetRowSpan(this.ppPicture, 5);
            this.ppPicture.Size = new System.Drawing.Size(129, 154);
            this.ppPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ppPicture.TabIndex = 1;
            this.ppPicture.TabStop = false;
            this.ppPicture.Click += new System.EventHandler(this.ppPicture_Click);
            // 
            // TitleInput
            // 
            this.TitleInput.Location = new System.Drawing.Point(215, 3);
            this.TitleInput.Name = "TitleInput";
            this.TitleInput.Size = new System.Drawing.Size(509, 20);
            this.TitleInput.TabIndex = 0;
            // 
            // CityInput
            // 
            this.CityInput.Location = new System.Drawing.Point(215, 73);
            this.CityInput.Name = "CityInput";
            this.CityInput.Size = new System.Drawing.Size(509, 20);
            this.CityInput.TabIndex = 3;
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(215, 103);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(509, 20);
            this.EmailInput.TabIndex = 4;
            // 
            // PhoneInput
            // 
            this.PhoneInput.Location = new System.Drawing.Point(215, 135);
            this.PhoneInput.Name = "PhoneInput";
            this.PhoneInput.Size = new System.Drawing.Size(509, 20);
            this.PhoneInput.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.PersonaPanel.SetRowSpan(this.label4, 5);
            this.label4.Size = new System.Drawing.Size(71, 160);
            this.label4.TabIndex = 6;
            this.label4.Text = "Persona";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(215, 38);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(509, 20);
            this.NameInput.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel2, 2);
            this.flowLayoutPanel2.Controls.Add(this.PersonaPanel);
            this.flowLayoutPanel2.Controls.Add(this.MiscPanel);
            this.flowLayoutPanel2.Controls.Add(this.categoriesPanel);
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel3);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 54);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1065, 630);
            this.flowLayoutPanel2.TabIndex = 1;

            this.PersonaPanel.ResumeLayout(false);
            this.PersonaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppPicture)).EndInit();

            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();

            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);

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

            Persona persona1 = new Persona(1, "Lambert Perrine", "Développeuse C#", "C:\\Users\\Formation\\Source\\Repos\\Estrani\\Cv_builder\\Media\\_4e0bf317-78b5-4d2c-a5f0-ee2cd81bbba8 1.png", "Graveson", "perrine.lambert24@gmail.com", "0606060606", miscs);

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

            Info calme = new Info(2, "Calme");
            List<Info> soft = new List<Info>() { calme };
            CategoryCv savoir_etre = new CategoryCv(2, "Savoir-être", "C:\\Users\\Formation\\Source\\Repos\\Estrani\\Cv_builder\\Media\\material-symbols_self-improvement (1).png", soft);


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
            CategoryCv cat = new CategoryCv(1, "Centre d'interets", "C:\\Users\\Formation\\Source\\Repos\\Estrani\\Cv_builder\\Media\\ci.png", l_infos);


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
            CategoryCv reseaux_sociaux = new CategoryCv(3, "Réseaux sociaux", "C:\\Users\\Formation\\Source\\Repos\\Estrani\\Cv_builder\\Media\\ion_share-social-sharp.png", social_net);


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
             Work work = new Work(1, 2024, "formation", "Arles", "Greta", "certif", l_infos, ".............................");
             List<Work> listW = new List<Work>() { work };
            CategoryCv exp = new CategoryCv(6, "Experiences Professionels", "^^^^", listW);


            Table expTable = allTables.Where(x => x.Title == "exp_tab").First();
            if (expTable != null)
            {
                Word.Cell expCell = expTable.Cell(1, 1);
                expCell.Range.Text = string.Join(" ", exp.GetIcon(), exp.GetTitle());

                Word.Cell expCell2 = expTable.Cell(2, 1);
                expCell2.Range.Text = string.Join("\r\n", exp.GetWorks().Select(x => x.GetWork()));
            }

            Table certifTable = allTables.Where(x => x.Title == "certif_tab").First();
            if (certifTable != null)
            {
                Word.Cell certifCell = certifTable.Cell(1, 1);
                certifCell.Range.Text = string.Join(" ", exp.GetIcon(), exp.GetTitle());

                Word.Cell certifCell2 = certifTable.Cell(2, 1);
                certifCell2.Range.Text = string.Join("\r\n", exp.GetWorks().Select(x => x.GetWork()));
            }

            List<CategoryCv> cater = new List<CategoryCv>() { cat, exp, tools, savoir_faire, savoir_etre,reseaux_sociaux };
             Cv cv = new Cv(1, persona1, cater);
            Engine nengine = new Engine(1, cv, "C:\\Users\\Formation\\Source\\Repos\\Estrani\\Cv_builder\\Template\\wordTemplate.docx");

            Backup newBackup = new Backup(1, nengine);
            newBackup.ToJsonFile();

            #endregion

            document.ExportAsFixedFormat(fichierFinal, Word.WdExportFormat.wdExportFormatPDF);

            // Evite d'enregistrer le fichier template avec les valeurs renseignées. 
            // Si non le fichier n'est plus utilisable
            wApp.Quit(SaveChanges: false);
        }


        private void Import_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
            
                Backup backupFile = new Backup();
                backupFile.ReadJsonFile(openFileDialog1.FileName);

                TitleInput.Text = backupFile.GetEngine().GetCv().GetPersona().GetTitle();
                Image image = Image.FromFile(backupFile.GetEngine().GetCv().GetPersona().GetPicture());
                ppPicture.Image = image;
                NameInput.Text = backupFile.GetEngine().GetCv().GetPersona().GetName();
                CityInput.Text = backupFile.GetEngine().GetCv().GetPersona().GetCity();
                EmailInput.Text = backupFile.GetEngine().GetCv().GetPersona().GetEmail();
                PhoneInput.Text = backupFile.GetEngine().GetCv().GetPersona().GetPhone();


                foreach (Misc misc in backupFile.GetEngine().GetCv().GetPersona().GetMiscs())
                {
                    System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                    textBox.Text = misc.GetExtra();
                    textBox.Width = 170;
                    MiscPanel.Controls.Add(textBox, 1, rowMisc);
                    rowMisc++;
                    MiscPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));


                }

                Image seimg = Image.FromFile(backupFile.GetEngine().GetCv().GetCategoryById(2).GetIcon());
                seIcon.Image = seimg;
                seInput.Text = backupFile.GetEngine().GetCv().GetCategoryById(2).GetTitle();

                foreach (Info info in backupFile.GetEngine().GetCv().GetCategoryById(2).GetInfos())
                {
                    System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                    textBox.Text = info.GetName();
                    textBox.Width = 170;
                    selayout.Controls.Add(textBox, 1, rowse);
                    rowse++;
                    selayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                }

                Image ciimg = Image.FromFile(backupFile.GetEngine().GetCv().GetCategoryById(1).GetIcon());
                hobbyImg.Image = ciimg;
                hobbyTitle.Text = backupFile.GetEngine().GetCv().GetCategoryById(1).GetTitle();

                foreach (Info info in backupFile.GetEngine().GetCv().GetCategoryById(1).GetInfos())
                {
                    System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                    textBox.Text = info.GetName();
                    textBox.Width = 170;
                    hobbypanel.Controls.Add(textBox, 1, rowci);
                    rowci++;
                    hobbypanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                }

                Image rsimg = Image.FromFile(backupFile.GetEngine().GetCv().GetCategoryById(3).GetIcon());
                rsImg.Image = rsimg;
                rsTitleInput.Text = backupFile.GetEngine().GetCv().GetCategoryById(3).GetTitle();

                foreach (Info info in backupFile.GetEngine().GetCv().GetCategoryById(3).GetInfos())
                {
                    System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                    textBox.Text = info.GetName();
                    textBox.Width = 170;
                    rsPanel.Controls.Add(textBox, 1, rowrs);
                    rowrs++;
                    rsPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                }

                sfInput.Text = backupFile.GetEngine().GetCv().GetCategoryById(4).GetTitle();

                foreach (Info info in backupFile.GetEngine().GetCv().GetCategoryById(4).GetInfos())
                {
                    System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                    textBox.Text = info.GetName();
                    textBox.Width = 170;
                    sfPanel.Controls.Add(textBox, 0, rowrs);
                    rowsf++;
                    sfPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                }

                umInput.Text = backupFile.GetEngine().GetCv().GetCategoryById(5).GetTitle();

                foreach (Info info in backupFile.GetEngine().GetCv().GetCategoryById(5).GetInfos())
                {
                    System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                    textBox.Text = info.GetName();
                    textBox.Width = 170;
                    umPanel.Controls.Add(textBox, 0, rowrs);
                    rowum++;
                    umPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                }

                epInput.Text = backupFile.GetEngine().GetCv().GetCategoryById(6).GetTitle();

                foreach (Work work in backupFile.GetEngine().GetCv().GetCategoryById(6).GetWorks())
                {
                    epPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                    System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                    textBox.Text = work.GetYear().ToString();
                    textBox.Width = 170;
                    epPanel.Controls.Add(textBox, 0, rowep);
                    rowep++;

                    epPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                    System.Windows.Forms.TextBox textBox2 = new System.Windows.Forms.TextBox();
                    textBox2.Text = work.GetTitle();
                    textBox2.Width = 170;
                    epPanel.Controls.Add(textBox2, 0, rowep);
                    rowep++;

                    epPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                    System.Windows.Forms.TextBox textBox3 = new System.Windows.Forms.TextBox();
                    textBox3.Text = work.GetOrganism();
                    textBox3.Width = 170;
                    epPanel.Controls.Add(textBox3, 0, rowep);
                    rowep++;

                    epPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                    System.Windows.Forms.TextBox textBox4 = new System.Windows.Forms.TextBox();
                    textBox4.Text = work.GetPlace();
                    textBox4.Width = 170;
                    epPanel.Controls.Add(textBox4, 0, rowep);
                    rowep++;
                    
                    //List skills 

                    epPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                    System.Windows.Forms.FlowLayoutPanel epSkillsPanel = new System.Windows.Forms.FlowLayoutPanel();
                    epPanel.Controls.Add(epSkillsPanel, 0, rowep);

                    foreach(Info skill in work.GetSkills())
                    {
                        System.Windows.Forms.TextBox skillwork = new System.Windows.Forms.TextBox();
                        skillwork.Text = skill.GetName().ToString();
                        skillwork.Width = 170;
                        epSkillsPanel.Controls.Add(skillwork);
                    }

                    System.Windows.Forms.Button addEpSkill = new System.Windows.Forms.Button();
                    addEpSkill.Text = "Ajout";
                    epPanel.Controls.Add(addEpSkill, 1, rowep);
                    rowep++;

                    epPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                    System.Windows.Forms.TextBox textBox5 = new System.Windows.Forms.TextBox();
                    textBox5.Text = work.GetDescription();
                    textBox5.Width = 170;
                    epPanel.Controls.Add(textBox5, 0, rowep);
                    rowep++;
                }


                dfInput.Text = backupFile.GetEngine().GetCv().GetCategoryById(6).GetTitle();

                foreach (Work work in backupFile.GetEngine().GetCv().GetCategoryById(6).GetWorks())
                {
                    dfPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                    System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                    textBox.Text = work.GetYear().ToString();
                    textBox.Width = 170;
                    dfPanel.Controls.Add(textBox, 0, rowdf);
                    rowdf++;

                    dfPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                    System.Windows.Forms.TextBox textBox2 = new System.Windows.Forms.TextBox();
                    textBox2.Text = work.GetTitle();
                    textBox2.Width = 170;
                    dfPanel.Controls.Add(textBox2, 0, rowdf);
                    rowdf++;

                    dfPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                    System.Windows.Forms.TextBox textBox3 = new System.Windows.Forms.TextBox();
                    textBox3.Text = work.GetOrganism();
                    textBox3.Width = 170;
                    dfPanel.Controls.Add(textBox3, 0, rowdf);
                    rowdf++;

                    dfPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                    System.Windows.Forms.TextBox textBox4 = new System.Windows.Forms.TextBox();
                    textBox4.Text = work.GetPlace();
                    textBox4.Width = 170;
                    dfPanel.Controls.Add(textBox4, 0, rowdf);
                    rowdf++;

                    //List skills 

                    dfPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                    System.Windows.Forms.FlowLayoutPanel dfSkillsPanel = new System.Windows.Forms.FlowLayoutPanel();
                    dfPanel.Controls.Add(dfSkillsPanel, 0, rowdf);

                    foreach (Info skill in work.GetSkills())
                    {
                        System.Windows.Forms.TextBox skillwork = new System.Windows.Forms.TextBox();
                        skillwork.Text = skill.GetName().ToString();
                        skillwork.Width = 170;
                        dfSkillsPanel.Controls.Add(skillwork);
                    }

                    System.Windows.Forms.Button addDfSkill = new System.Windows.Forms.Button();
                    addDfSkill.Text = "Ajout";
                    dfPanel.Controls.Add(addDfSkill, 1, rowdf);
                    rowdf++;

                    dfPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                    System.Windows.Forms.TextBox textBox5 = new System.Windows.Forms.TextBox();
                    textBox5.Text = work.GetDescription();
                    textBox5.Width = 170;
                    dfPanel.Controls.Add(textBox5, 0, rowdf);
                    rowdf++;
                }

            }
        }

      

        private void ppPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                ppPicture.Load(openFileDialog2.FileName);
            }
        }


        private void hobbyImg_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                hobbyImg.Load(openFileDialog2.FileName);
            }
        }

        private void seIcon_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                seIcon.Load(openFileDialog2.FileName);
            }
        }

        private void rsImg_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                rsImg.Load(openFileDialog2.FileName);
            }
        }

        int rowAddMisc = 0;
        private void AddMisc_Click(object sender, EventArgs e)
        {
            MiscPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            rowMisc++;

            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
            textBox.Width = 170;
            MiscPanel.Controls.Add(textBox, 1, rowMisc);

        }

        private void AddHobby_Click(object sender, EventArgs e)
        {
            hobbypanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            rowci++;

            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
            textBox.Width = 170;
            hobbypanel.Controls.Add(textBox, 1, rowci);
        }

        int rowAddse = 0;
        private void AddSe_Click(object sender, EventArgs e)
        {
            selayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            rowse++;

            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
            textBox.Width = 170;
            selayout.Controls.Add(textBox, 1, rowse);
        }

        int rowAddrs = 0;
        private void AddRs_Click(object sender, EventArgs e)
        {
            rsPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            rowrs++;

            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
            textBox.Width = 170;
            rsPanel.Controls.Add(textBox, 1, rowrs);
        }

        int rowAddsf = 0;
        private void AddSf_Click(object sender, EventArgs e)
        {
            sfPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            rowsf++;

            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
            textBox.Width = 170;
            sfPanel.Controls.Add(textBox, 0, rowsf);
        }

        int rowAddum = 0;
        private void AddUm_Click(object sender, EventArgs e)
        {
            umPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            rowum++;

            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
            textBox.Width = 170;
            umPanel.Controls.Add(textBox, 0, rowum);
        }

        int rowcat = 5;
        private void AddCategory_Click(object sender, EventArgs e)
        {
            categoriesPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            rowcat++;
            System.Windows.Forms.TableLayoutPanel newCat = new System.Windows.Forms.TableLayoutPanel();
            categoriesPanel.Controls.Add(newCat, 0, rowcat);
            categoriesPanel.SetColumnSpan(newCat, 3);
            // tablelayoutpanel construction
            newCat.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            newCat.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            newCat.Dock = DockStyle.Fill;

            System.Windows.Forms.PictureBox catIcon = new System.Windows.Forms.PictureBox();
            catIcon.BorderStyle = BorderStyle.FixedSingle;
            newCat.Controls.Add(catIcon, 0, 0);
            System.Windows.Forms.TextBox catTitle = new System.Windows.Forms.TextBox();
            newCat.Controls.Add(catTitle, 1, 0);
            System.Windows.Forms.Button catAdd = new System.Windows.Forms.Button();
            catAdd.Text = "Ajout";
            newCat.Controls.Add(catAdd, 3, 0);
        }

    }
}
