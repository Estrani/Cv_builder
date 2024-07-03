namespace PublipostageDemo
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Import = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.generate = new System.Windows.Forms.Button();
            this.MiscPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.AddMisc = new System.Windows.Forms.Button();
            this.categoriesPanel = new System.Windows.Forms.TableLayoutPanel();
            this.umPanel = new System.Windows.Forms.TableLayoutPanel();
            this.umInput = new System.Windows.Forms.TextBox();
            this.AddUm = new System.Windows.Forms.Button();
            this.sfPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sfInput = new System.Windows.Forms.TextBox();
            this.AddSf = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AddCategory = new System.Windows.Forms.Button();
            this.hobbypanel = new System.Windows.Forms.TableLayoutPanel();
            this.hobbyImg = new System.Windows.Forms.PictureBox();
            this.hobbyTitle = new System.Windows.Forms.TextBox();
            this.AddHobby = new System.Windows.Forms.Button();
            this.rsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.rsImg = new System.Windows.Forms.PictureBox();
            this.rsTitleInput = new System.Windows.Forms.TextBox();
            this.AddRs = new System.Windows.Forms.Button();
            this.selayout = new System.Windows.Forms.TableLayoutPanel();
            this.seIcon = new System.Windows.Forms.PictureBox();
            this.seInput = new System.Windows.Forms.TextBox();
            this.AddSe = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.AddWork = new System.Windows.Forms.Button();
            this.epPanel = new System.Windows.Forms.TableLayoutPanel();
            this.epInput = new System.Windows.Forms.TextBox();
            this.AddEp = new System.Windows.Forms.Button();
            this.dfPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dfInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.MiscPanel.SuspendLayout();
            this.categoriesPanel.SuspendLayout();
            this.umPanel.SuspendLayout();
            this.sfPanel.SuspendLayout();
            this.hobbypanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hobbyImg)).BeginInit();
            this.rsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rsImg)).BeginInit();
            this.selayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seIcon)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.epPanel.SuspendLayout();
            this.dfPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.102273F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1071, 687);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.Import);
            this.flowLayoutPanel1.Controls.Add(this.Export);
            this.flowLayoutPanel1.Controls.Add(this.generate);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1065, 45);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(3, 3);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(75, 23);
            this.Import.TabIndex = 0;
            this.Import.Text = "Importer";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(84, 3);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(75, 23);
            this.Export.TabIndex = 1;
            this.Export.Text = "Exporter";
            this.Export.UseVisualStyleBackColor = true;
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(165, 3);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(112, 23);
            this.generate.TabIndex = 3;
            this.generate.Text = "Generate Word ! ";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // MiscPanel
            // 
            this.MiscPanel.AutoSize = true;
            this.MiscPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.MiscPanel.ColumnCount = 2;
            this.MiscPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.63275F));
            this.MiscPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.36725F));
            this.MiscPanel.Controls.Add(this.label1, 0, 0);
            this.MiscPanel.Controls.Add(this.AddMisc, 1, 0);
            this.MiscPanel.Location = new System.Drawing.Point(3, 169);
            this.MiscPanel.Name = "MiscPanel";
            this.MiscPanel.RowCount = 1;
            this.MiscPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.61538F));
            this.MiscPanel.Size = new System.Drawing.Size(877, 100);
            this.MiscPanel.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "Infos suplémentaires";
            // 
            // AddMisc
            // 
            this.AddMisc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddMisc.Location = new System.Drawing.Point(141, 4);
            this.AddMisc.Name = "AddMisc";
            this.AddMisc.Size = new System.Drawing.Size(732, 92);
            this.AddMisc.TabIndex = 1;
            this.AddMisc.Text = "Ajout";
            this.AddMisc.UseVisualStyleBackColor = true;
            this.AddMisc.Click += new System.EventHandler(this.AddMisc_Click);
            // 
            // categoriesPanel
            // 
            this.categoriesPanel.AutoSize = true;
            this.categoriesPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.categoriesPanel.ColumnCount = 2;
            this.categoriesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.categoriesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.categoriesPanel.Controls.Add(this.umPanel, 0, 5);
            this.categoriesPanel.Controls.Add(this.sfPanel, 0, 4);
            this.categoriesPanel.Controls.Add(this.label2, 0, 0);
            this.categoriesPanel.Controls.Add(this.AddCategory, 1, 0);
            this.categoriesPanel.Controls.Add(this.hobbypanel, 0, 1);
            this.categoriesPanel.Controls.Add(this.rsPanel, 0, 3);
            this.categoriesPanel.Controls.Add(this.selayout, 0, 2);
            this.categoriesPanel.Location = new System.Drawing.Point(3, 275);
            this.categoriesPanel.Name = "categoriesPanel";
            this.categoriesPanel.RowCount = 6;
            this.categoriesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.categoriesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.categoriesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.categoriesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.categoriesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.categoriesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.categoriesPanel.Size = new System.Drawing.Size(449, 319);
            this.categoriesPanel.TabIndex = 14;
            // 
            // umPanel
            // 
            this.umPanel.AutoSize = true;
            this.umPanel.ColumnCount = 2;
            this.categoriesPanel.SetColumnSpan(this.umPanel, 2);
            this.umPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.umPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.umPanel.Controls.Add(this.umInput, 0, 0);
            this.umPanel.Controls.Add(this.AddUm, 1, 0);
            this.umPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.umPanel.Location = new System.Drawing.Point(3, 287);
            this.umPanel.Margin = new System.Windows.Forms.Padding(2);
            this.umPanel.Name = "umPanel";
            this.umPanel.RowCount = 1;
            this.umPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.92308F));
            this.umPanel.Size = new System.Drawing.Size(443, 29);
            this.umPanel.TabIndex = 4;
            // 
            // umInput
            // 
            this.umInput.Location = new System.Drawing.Point(2, 2);
            this.umInput.Margin = new System.Windows.Forms.Padding(2);
            this.umInput.Name = "umInput";
            this.umInput.Size = new System.Drawing.Size(288, 20);
            this.umInput.TabIndex = 2;
            this.umInput.Text = "Outils Maitrisés";
            // 
            // AddUm
            // 
            this.AddUm.Location = new System.Drawing.Point(374, 3);
            this.AddUm.Name = "AddUm";
            this.AddUm.Size = new System.Drawing.Size(66, 23);
            this.AddUm.TabIndex = 3;
            this.AddUm.Text = "Ajout";
            this.AddUm.UseVisualStyleBackColor = true;
            this.AddUm.Click += new System.EventHandler(this.AddUm_Click);
            // 
            // sfPanel
            // 
            this.sfPanel.AutoSize = true;
            this.sfPanel.ColumnCount = 2;
            this.categoriesPanel.SetColumnSpan(this.sfPanel, 2);
            this.sfPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sfPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.sfPanel.Controls.Add(this.sfInput, 0, 0);
            this.sfPanel.Controls.Add(this.AddSf, 1, 0);
            this.sfPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfPanel.Location = new System.Drawing.Point(3, 253);
            this.sfPanel.Margin = new System.Windows.Forms.Padding(2);
            this.sfPanel.Name = "sfPanel";
            this.sfPanel.RowCount = 1;
            this.sfPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.45946F));
            this.sfPanel.Size = new System.Drawing.Size(443, 29);
            this.sfPanel.TabIndex = 3;
            // 
            // sfInput
            // 
            this.sfInput.Location = new System.Drawing.Point(2, 2);
            this.sfInput.Margin = new System.Windows.Forms.Padding(2);
            this.sfInput.Name = "sfInput";
            this.sfInput.Size = new System.Drawing.Size(288, 20);
            this.sfInput.TabIndex = 1;
            this.sfInput.Text = "Savoir-faire";
            // 
            // AddSf
            // 
            this.AddSf.Location = new System.Drawing.Point(376, 3);
            this.AddSf.Name = "AddSf";
            this.AddSf.Size = new System.Drawing.Size(64, 23);
            this.AddSf.TabIndex = 2;
            this.AddSf.Text = "Ajout";
            this.AddSf.UseVisualStyleBackColor = true;
            this.AddSf.Click += new System.EventHandler(this.AddSf_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Catégories";
            // 
            // AddCategory
            // 
            this.AddCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddCategory.Location = new System.Drawing.Point(68, 4);
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.Size = new System.Drawing.Size(377, 62);
            this.AddCategory.TabIndex = 1;
            this.AddCategory.Text = "Ajout";
            this.AddCategory.UseVisualStyleBackColor = true;
            this.AddCategory.Click += new System.EventHandler(this.AddCategory_Click);
            // 
            // hobbypanel
            // 
            this.hobbypanel.AutoSize = true;
            this.hobbypanel.ColumnCount = 3;
            this.categoriesPanel.SetColumnSpan(this.hobbypanel, 2);
            this.hobbypanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.35371F));
            this.hobbypanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.64629F));
            this.hobbypanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.hobbypanel.Controls.Add(this.hobbyImg, 0, 0);
            this.hobbypanel.Controls.Add(this.hobbyTitle, 1, 0);
            this.hobbypanel.Controls.Add(this.AddHobby, 2, 0);
            this.hobbypanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hobbypanel.Location = new System.Drawing.Point(3, 72);
            this.hobbypanel.Margin = new System.Windows.Forms.Padding(2);
            this.hobbypanel.Name = "hobbypanel";
            this.hobbypanel.RowCount = 1;
            this.hobbypanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.hobbypanel.Size = new System.Drawing.Size(443, 55);
            this.hobbypanel.TabIndex = 8;
            // 
            // hobbyImg
            // 
            this.hobbyImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hobbyImg.Location = new System.Drawing.Point(2, 2);
            this.hobbyImg.Margin = new System.Windows.Forms.Padding(2);
            this.hobbyImg.Name = "hobbyImg";
            this.hobbyImg.Size = new System.Drawing.Size(38, 51);
            this.hobbyImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hobbyImg.TabIndex = 0;
            this.hobbyImg.TabStop = false;
            this.hobbyImg.Click += new System.EventHandler(this.hobbyImg_Click);
            // 
            // hobbyTitle
            // 
            this.hobbyTitle.Location = new System.Drawing.Point(44, 2);
            this.hobbyTitle.Margin = new System.Windows.Forms.Padding(2);
            this.hobbyTitle.Name = "hobbyTitle";
            this.hobbyTitle.Size = new System.Drawing.Size(256, 20);
            this.hobbyTitle.TabIndex = 1;
            this.hobbyTitle.Text = "Centres d\'interets";
            // 
            // AddHobby
            // 
            this.AddHobby.Location = new System.Drawing.Point(375, 3);
            this.AddHobby.Name = "AddHobby";
            this.AddHobby.Size = new System.Drawing.Size(60, 22);
            this.AddHobby.TabIndex = 2;
            this.AddHobby.Text = "Ajout";
            this.AddHobby.UseVisualStyleBackColor = true;
            this.AddHobby.Click += new System.EventHandler(this.AddHobby_Click);
            // 
            // rsPanel
            // 
            this.rsPanel.AutoSize = true;
            this.rsPanel.ColumnCount = 3;
            this.categoriesPanel.SetColumnSpan(this.rsPanel, 2);
            this.rsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.48035F));
            this.rsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.51965F));
            this.rsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.rsPanel.Controls.Add(this.rsImg, 0, 0);
            this.rsPanel.Controls.Add(this.rsTitleInput, 1, 0);
            this.rsPanel.Controls.Add(this.AddRs, 2, 0);
            this.rsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rsPanel.Location = new System.Drawing.Point(3, 191);
            this.rsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.rsPanel.Name = "rsPanel";
            this.rsPanel.RowCount = 1;
            this.rsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.73771F));
            this.rsPanel.Size = new System.Drawing.Size(443, 57);
            this.rsPanel.TabIndex = 9;
            // 
            // rsImg
            // 
            this.rsImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rsImg.Location = new System.Drawing.Point(2, 2);
            this.rsImg.Margin = new System.Windows.Forms.Padding(2);
            this.rsImg.Name = "rsImg";
            this.rsImg.Size = new System.Drawing.Size(34, 53);
            this.rsImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rsImg.TabIndex = 0;
            this.rsImg.TabStop = false;
            this.rsImg.Click += new System.EventHandler(this.rsImg_Click);
            // 
            // rsTitleInput
            // 
            this.rsTitleInput.Location = new System.Drawing.Point(40, 2);
            this.rsTitleInput.Margin = new System.Windows.Forms.Padding(2);
            this.rsTitleInput.Name = "rsTitleInput";
            this.rsTitleInput.Size = new System.Drawing.Size(256, 20);
            this.rsTitleInput.TabIndex = 1;
            this.rsTitleInput.Text = "Réseaux sociaux";
            // 
            // AddRs
            // 
            this.AddRs.Location = new System.Drawing.Point(370, 3);
            this.AddRs.Name = "AddRs";
            this.AddRs.Size = new System.Drawing.Size(64, 23);
            this.AddRs.TabIndex = 2;
            this.AddRs.Text = "Ajout";
            this.AddRs.UseVisualStyleBackColor = true;
            this.AddRs.Click += new System.EventHandler(this.AddRs_Click);
            // 
            // selayout
            // 
            this.selayout.AutoSize = true;
            this.selayout.ColumnCount = 3;
            this.categoriesPanel.SetColumnSpan(this.selayout, 2);
            this.selayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.35371F));
            this.selayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.64629F));
            this.selayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.selayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.selayout.Controls.Add(this.seIcon, 0, 0);
            this.selayout.Controls.Add(this.seInput, 1, 0);
            this.selayout.Controls.Add(this.AddSe, 2, 0);
            this.selayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selayout.Location = new System.Drawing.Point(3, 132);
            this.selayout.Margin = new System.Windows.Forms.Padding(2);
            this.selayout.Name = "selayout";
            this.selayout.RowCount = 1;
            this.selayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.17391F));
            this.selayout.Size = new System.Drawing.Size(443, 54);
            this.selayout.TabIndex = 7;
            // 
            // seIcon
            // 
            this.seIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seIcon.Location = new System.Drawing.Point(2, 2);
            this.seIcon.Margin = new System.Windows.Forms.Padding(2);
            this.seIcon.Name = "seIcon";
            this.seIcon.Size = new System.Drawing.Size(38, 50);
            this.seIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.seIcon.TabIndex = 0;
            this.seIcon.TabStop = false;
            this.seIcon.Click += new System.EventHandler(this.seIcon_Click);
            // 
            // seInput
            // 
            this.seInput.Location = new System.Drawing.Point(44, 2);
            this.seInput.Margin = new System.Windows.Forms.Padding(2);
            this.seInput.Name = "seInput";
            this.seInput.Size = new System.Drawing.Size(256, 20);
            this.seInput.TabIndex = 1;
            this.seInput.Text = "Savaoir-être";
            // 
            // AddSe
            // 
            this.AddSe.Location = new System.Drawing.Point(372, 3);
            this.AddSe.Name = "AddSe";
            this.AddSe.Size = new System.Drawing.Size(62, 22);
            this.AddSe.TabIndex = 2;
            this.AddSe.Text = "Ajout";
            this.AddSe.UseVisualStyleBackColor = true;
            this.AddSe.Click += new System.EventHandler(this.AddSe_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.AddWork, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.epPanel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dfPanel, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 600);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(651, 121);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 52);
            this.label3.TabIndex = 0;
            this.label3.Text = "Traveaux";
            // 
            // AddWork
            // 
            this.AddWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddWork.Location = new System.Drawing.Point(63, 4);
            this.AddWork.Name = "AddWork";
            this.AddWork.Size = new System.Drawing.Size(584, 46);
            this.AddWork.TabIndex = 1;
            this.AddWork.Text = "Ajout";
            this.AddWork.UseVisualStyleBackColor = true;
            // 
            // epPanel
            // 
            this.epPanel.AutoSize = true;
            this.epPanel.ColumnCount = 2;
            this.tableLayoutPanel3.SetColumnSpan(this.epPanel, 2);
            this.epPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.epPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.epPanel.Controls.Add(this.epInput, 0, 0);
            this.epPanel.Controls.Add(this.AddEp, 1, 0);
            this.epPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.epPanel.Location = new System.Drawing.Point(3, 56);
            this.epPanel.Margin = new System.Windows.Forms.Padding(2);
            this.epPanel.Name = "epPanel";
            this.epPanel.RowCount = 1;
            this.epPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.epPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.epPanel.Size = new System.Drawing.Size(645, 28);
            this.epPanel.TabIndex = 11;
            // 
            // epInput
            // 
            this.epInput.Location = new System.Drawing.Point(2, 2);
            this.epInput.Margin = new System.Windows.Forms.Padding(2);
            this.epInput.Name = "epInput";
            this.epInput.Size = new System.Drawing.Size(193, 20);
            this.epInput.TabIndex = 0;
            this.epInput.Text = "Experiences Professionnels";
            // 
            // AddEp
            // 
            this.AddEp.Location = new System.Drawing.Point(464, 3);
            this.AddEp.Name = "AddEp";
            this.AddEp.Size = new System.Drawing.Size(75, 22);
            this.AddEp.TabIndex = 1;
            this.AddEp.Text = "Ajout";
            this.AddEp.UseVisualStyleBackColor = true;
            // 
            // dfPanel
            // 
            this.dfPanel.AutoSize = true;
            this.dfPanel.ColumnCount = 2;
            this.tableLayoutPanel3.SetColumnSpan(this.dfPanel, 2);
            this.dfPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dfPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.dfPanel.Controls.Add(this.dfInput, 0, 0);
            this.dfPanel.Controls.Add(this.button1, 1, 0);
            this.dfPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dfPanel.Location = new System.Drawing.Point(3, 89);
            this.dfPanel.Margin = new System.Windows.Forms.Padding(2);
            this.dfPanel.Name = "dfPanel";
            this.dfPanel.RowCount = 1;
            this.dfPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dfPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.dfPanel.Size = new System.Drawing.Size(645, 29);
            this.dfPanel.TabIndex = 12;
            // 
            // dfInput
            // 
            this.dfInput.Location = new System.Drawing.Point(2, 2);
            this.dfInput.Margin = new System.Windows.Forms.Padding(2);
            this.dfInput.Name = "dfInput";
            this.dfInput.Size = new System.Drawing.Size(166, 20);
            this.dfInput.TabIndex = 0;
            this.dfInput.Text = "Diplômes et Formations";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ajout";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JSON Files (*.json)|*.json|All files (*.*)|*.*";
            this.openFileDialog1.Title = "Import";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 687);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.MiscPanel.ResumeLayout(false);
            this.MiscPanel.PerformLayout();
            this.categoriesPanel.ResumeLayout(false);
            this.categoriesPanel.PerformLayout();
            this.umPanel.ResumeLayout(false);
            this.umPanel.PerformLayout();
            this.sfPanel.ResumeLayout(false);
            this.sfPanel.PerformLayout();
            this.hobbypanel.ResumeLayout(false);
            this.hobbypanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hobbyImg)).EndInit();
            this.rsPanel.ResumeLayout(false);
            this.rsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rsImg)).EndInit();
            this.selayout.ResumeLayout(false);
            this.selayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seIcon)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.epPanel.ResumeLayout(false);
            this.epPanel.PerformLayout();
            this.dfPanel.ResumeLayout(false);
            this.dfPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
       
        private System.Windows.Forms.TableLayoutPanel selayout;
        private System.Windows.Forms.PictureBox seIcon;
        private System.Windows.Forms.TextBox seInput;
        private System.Windows.Forms.TableLayoutPanel hobbypanel;
        private System.Windows.Forms.PictureBox hobbyImg;
        private System.Windows.Forms.TextBox hobbyTitle;
        private System.Windows.Forms.TableLayoutPanel rsPanel;
        private System.Windows.Forms.PictureBox rsImg;
        private System.Windows.Forms.TextBox rsTitleInput;
        private System.Windows.Forms.TableLayoutPanel sfPanel;
        private System.Windows.Forms.TextBox sfInput;
        private System.Windows.Forms.TableLayoutPanel umPanel;
        private System.Windows.Forms.TextBox umInput;
        private System.Windows.Forms.TableLayoutPanel epPanel;
        private System.Windows.Forms.TextBox epInput;
        private System.Windows.Forms.TableLayoutPanel MiscPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddMisc;
        private System.Windows.Forms.TableLayoutPanel categoriesPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddCategory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddWork;
        private System.Windows.Forms.Button AddEp;
        private System.Windows.Forms.Button AddHobby;
        private System.Windows.Forms.Button AddUm;
        private System.Windows.Forms.Button AddSf;
        private System.Windows.Forms.Button AddRs;
        private System.Windows.Forms.Button AddSe;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.TableLayoutPanel dfPanel;
        private System.Windows.Forms.TextBox dfInput;
        private System.Windows.Forms.Button button1;
    }
}

