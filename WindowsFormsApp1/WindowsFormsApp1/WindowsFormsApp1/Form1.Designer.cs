namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FiliereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet2 = new WindowsFormsApp1.DataSet2();
            this.statistic = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ajouter_filiere = new System.Windows.Forms.Button();
            this.nom_filiere = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textfiliere_mod = new System.Windows.Forms.TextBox();
            this.valid_filiere = new System.Windows.Forms.Button();
            this.remove_filiere = new System.Windows.Forms.Button();
            this.mod_filiere = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cboSheet = new System.Windows.Forms.ComboBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.sheet = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tri_decroiss = new System.Windows.Forms.Button();
            this.tri_croiss = new System.Windows.Forms.Button();
            this.charger_etd = new System.Windows.Forms.Button();
            this.import_data = new System.Windows.Forms.Button();
            this.supprimer_etd = new System.Windows.Forms.Button();
            this.modifier_etd = new System.Windows.Forms.Button();
            this.ajouter_etd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.list_filiere = new System.Windows.Forms.ListBox();
            this.check_F = new System.Windows.Forms.CheckBox();
            this.check_Homme = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tele_etudiant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adresse_etudiant = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.prenom_etudiant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nom_etudiant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cne_etudiant = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.etudiant_stat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CneTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.AfficherCne = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.AfficherTous = new System.Windows.Forms.Button();
            this.FiliereTableAdapter = new WindowsFormsApp1.DataSet2TableAdapters.FiliereTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FiliereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            this.statistic.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.etudiant_stat)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // FiliereBindingSource
            // 
            this.FiliereBindingSource.DataMember = "Filiere";
            this.FiliereBindingSource.DataSource = this.DataSet2;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statistic
            // 
            this.statistic.Controls.Add(this.tabPage1);
            this.statistic.Controls.Add(this.tabPage2);
            this.statistic.Controls.Add(this.tabPage3);
            this.statistic.Controls.Add(this.tabPage4);
            this.statistic.Location = new System.Drawing.Point(3, 0);
            this.statistic.Name = "statistic";
            this.statistic.SelectedIndex = 0;
            this.statistic.Size = new System.Drawing.Size(733, 477);
            this.statistic.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.remove_filiere);
            this.tabPage1.Controls.Add(this.mod_filiere);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(725, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filière";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ajouter_filiere);
            this.groupBox2.Controls.Add(this.nom_filiere);
            this.groupBox2.Location = new System.Drawing.Point(34, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 109);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ajouter une filière ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom de filière :";
            // 
            // ajouter_filiere
            // 
            this.ajouter_filiere.Location = new System.Drawing.Point(115, 52);
            this.ajouter_filiere.Name = "ajouter_filiere";
            this.ajouter_filiere.Size = new System.Drawing.Size(75, 22);
            this.ajouter_filiere.TabIndex = 0;
            this.ajouter_filiere.Text = "Ajouter";
            this.ajouter_filiere.UseVisualStyleBackColor = true;
            this.ajouter_filiere.Click += new System.EventHandler(this.ajouter_filiere_Click);
            // 
            // nom_filiere
            // 
            this.nom_filiere.Location = new System.Drawing.Point(89, 26);
            this.nom_filiere.Name = "nom_filiere";
            this.nom_filiere.Size = new System.Drawing.Size(127, 20);
            this.nom_filiere.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(372, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(279, 185);
            this.dataGridView1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textfiliere_mod);
            this.panel1.Controls.Add(this.valid_filiere);
            this.panel1.Location = new System.Drawing.Point(123, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 106);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(186, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Nouveau Nom : ";
            // 
            // textfiliere_mod
            // 
            this.textfiliere_mod.Location = new System.Drawing.Point(104, 36);
            this.textfiliere_mod.Name = "textfiliere_mod";
            this.textfiliere_mod.Size = new System.Drawing.Size(100, 20);
            this.textfiliere_mod.TabIndex = 2;
            // 
            // valid_filiere
            // 
            this.valid_filiere.Location = new System.Drawing.Point(63, 71);
            this.valid_filiere.Name = "valid_filiere";
            this.valid_filiere.Size = new System.Drawing.Size(75, 23);
            this.valid_filiere.TabIndex = 1;
            this.valid_filiere.Text = "Valide";
            this.valid_filiere.UseVisualStyleBackColor = true;
            this.valid_filiere.Click += new System.EventHandler(this.valid_filiere_Click);
            // 
            // remove_filiere
            // 
            this.remove_filiere.Location = new System.Drawing.Point(516, 313);
            this.remove_filiere.Name = "remove_filiere";
            this.remove_filiere.Size = new System.Drawing.Size(75, 23);
            this.remove_filiere.TabIndex = 2;
            this.remove_filiere.Text = "Supprimer";
            this.remove_filiere.UseVisualStyleBackColor = true;
            this.remove_filiere.Click += new System.EventHandler(this.remove_filiere_Click);
            // 
            // mod_filiere
            // 
            this.mod_filiere.Location = new System.Drawing.Point(422, 313);
            this.mod_filiere.Name = "mod_filiere";
            this.mod_filiere.Size = new System.Drawing.Size(75, 23);
            this.mod_filiere.TabIndex = 1;
            this.mod_filiere.Text = "Modifier";
            this.mod_filiere.UseVisualStyleBackColor = true;
            this.mod_filiere.Click += new System.EventHandler(this.mod_filiere_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.tri_decroiss);
            this.tabPage2.Controls.Add(this.tri_croiss);
            this.tabPage2.Controls.Add(this.charger_etd);
            this.tabPage2.Controls.Add(this.import_data);
            this.tabPage2.Controls.Add(this.supprimer_etd);
            this.tabPage2.Controls.Add(this.modifier_etd);
            this.tabPage2.Controls.Add(this.ajouter_etd);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(725, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Etudiant";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.cboSheet);
            this.panel2.Controls.Add(this.txtFilename);
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Controls.Add(this.sheet);
            this.panel2.Controls.Add(this.btnBrowse);
            this.panel2.Location = new System.Drawing.Point(311, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 291);
            this.panel2.TabIndex = 11;
            this.panel2.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(257, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboSheet
            // 
            this.cboSheet.FormattingEnabled = true;
            this.cboSheet.Location = new System.Drawing.Point(128, 79);
            this.cboSheet.Name = "cboSheet";
            this.cboSheet.Size = new System.Drawing.Size(134, 21);
            this.cboSheet.TabIndex = 5;
            this.cboSheet.SelectedIndexChanged += new System.EventHandler(this.cboSheet_SelectedIndexChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(17, 124);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(259, 147);
            this.dataGridView3.TabIndex = 4;
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(128, 38);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(134, 20);
            this.txtFilename.TabIndex = 2;
            // 
            // sheet
            // 
            this.sheet.Location = new System.Drawing.Point(17, 79);
            this.sheet.Name = "sheet";
            this.sheet.Size = new System.Drawing.Size(75, 23);
            this.sheet.TabIndex = 1;
            this.sheet.Text = "sheet";
            this.sheet.UseVisualStyleBackColor = true;
            this.sheet.Click += new System.EventHandler(this.sheet_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(17, 36);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Selectionner";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(311, 78);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(388, 273);
            this.dataGridView2.TabIndex = 10;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selected_etd);
            // 
            // tri_decroiss
            // 
            this.tri_decroiss.Location = new System.Drawing.Point(602, 49);
            this.tri_decroiss.Name = "tri_decroiss";
            this.tri_decroiss.Size = new System.Drawing.Size(97, 23);
            this.tri_decroiss.TabIndex = 9;
            this.tri_decroiss.Text = "Tri Décroissant";
            this.tri_decroiss.UseVisualStyleBackColor = true;
            this.tri_decroiss.Click += new System.EventHandler(this.tri_decroiss_Click);
            // 
            // tri_croiss
            // 
            this.tri_croiss.Location = new System.Drawing.Point(480, 49);
            this.tri_croiss.Name = "tri_croiss";
            this.tri_croiss.Size = new System.Drawing.Size(83, 23);
            this.tri_croiss.TabIndex = 8;
            this.tri_croiss.Text = "Tri Croissant";
            this.tri_croiss.UseVisualStyleBackColor = true;
            this.tri_croiss.Click += new System.EventHandler(this.tri_croiss_Click);
            // 
            // charger_etd
            // 
            this.charger_etd.Location = new System.Drawing.Point(311, 49);
            this.charger_etd.Name = "charger_etd";
            this.charger_etd.Size = new System.Drawing.Size(120, 23);
            this.charger_etd.TabIndex = 7;
            this.charger_etd.Text = "Charger les données";
            this.charger_etd.UseVisualStyleBackColor = true;
            this.charger_etd.Click += new System.EventHandler(this.charger_etd_Click);
            // 
            // import_data
            // 
            this.import_data.Location = new System.Drawing.Point(374, 378);
            this.import_data.Name = "import_data";
            this.import_data.Size = new System.Drawing.Size(75, 23);
            this.import_data.TabIndex = 6;
            this.import_data.Text = "Importer";
            this.import_data.UseVisualStyleBackColor = true;
            this.import_data.Click += new System.EventHandler(this.import_data_Click);
            // 
            // supprimer_etd
            // 
            this.supprimer_etd.Location = new System.Drawing.Point(268, 378);
            this.supprimer_etd.Name = "supprimer_etd";
            this.supprimer_etd.Size = new System.Drawing.Size(75, 23);
            this.supprimer_etd.TabIndex = 5;
            this.supprimer_etd.Text = "Supprimer";
            this.supprimer_etd.UseVisualStyleBackColor = true;
            this.supprimer_etd.Click += new System.EventHandler(this.supprimer_etd_Click);
            // 
            // modifier_etd
            // 
            this.modifier_etd.Location = new System.Drawing.Point(165, 378);
            this.modifier_etd.Name = "modifier_etd";
            this.modifier_etd.Size = new System.Drawing.Size(75, 23);
            this.modifier_etd.TabIndex = 4;
            this.modifier_etd.Text = "Modifier";
            this.modifier_etd.UseVisualStyleBackColor = true;
            this.modifier_etd.Click += new System.EventHandler(this.modifier_etd_Click);
            // 
            // ajouter_etd
            // 
            this.ajouter_etd.Location = new System.Drawing.Point(54, 378);
            this.ajouter_etd.Name = "ajouter_etd";
            this.ajouter_etd.Size = new System.Drawing.Size(75, 23);
            this.ajouter_etd.TabIndex = 3;
            this.ajouter_etd.Text = "Ajouter";
            this.ajouter_etd.UseVisualStyleBackColor = true;
            this.ajouter_etd.Click += new System.EventHandler(this.ajouter_etd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.list_filiere);
            this.groupBox1.Controls.Add(this.check_F);
            this.groupBox1.Controls.Add(this.check_Homme);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tele_etudiant);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.adresse_etudiant);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.prenom_etudiant);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nom_etudiant);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cne_etudiant);
            this.groupBox1.Location = new System.Drawing.Point(20, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 302);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations Etudiant";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 186);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // list_filiere
            // 
            this.list_filiere.FormattingEnabled = true;
            this.list_filiere.Location = new System.Drawing.Point(115, 257);
            this.list_filiere.Name = "list_filiere";
            this.list_filiere.Size = new System.Drawing.Size(120, 17);
            this.list_filiere.TabIndex = 43;
            // 
            // check_F
            // 
            this.check_F.AutoSize = true;
            this.check_F.Location = new System.Drawing.Point(173, 224);
            this.check_F.Name = "check_F";
            this.check_F.Size = new System.Drawing.Size(32, 17);
            this.check_F.TabIndex = 42;
            this.check_F.Text = "F";
            this.check_F.UseVisualStyleBackColor = true;
            // 
            // check_Homme
            // 
            this.check_Homme.AutoSize = true;
            this.check_Homme.Location = new System.Drawing.Point(120, 224);
            this.check_Homme.Name = "check_Homme";
            this.check_Homme.Size = new System.Drawing.Size(35, 17);
            this.check_Homme.TabIndex = 41;
            this.check_Homme.Text = "M";
            this.check_Homme.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Sexe :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Filière :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Date de Naissance :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Téléphone :";
            // 
            // tele_etudiant
            // 
            this.tele_etudiant.Location = new System.Drawing.Point(120, 152);
            this.tele_etudiant.Name = "tele_etudiant";
            this.tele_etudiant.Size = new System.Drawing.Size(100, 20);
            this.tele_etudiant.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Adresse :";
            // 
            // adresse_etudiant
            // 
            this.adresse_etudiant.Location = new System.Drawing.Point(120, 116);
            this.adresse_etudiant.Name = "adresse_etudiant";
            this.adresse_etudiant.Size = new System.Drawing.Size(100, 20);
            this.adresse_etudiant.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Prénom  :";
            // 
            // prenom_etudiant
            // 
            this.prenom_etudiant.Location = new System.Drawing.Point(120, 83);
            this.prenom_etudiant.Name = "prenom_etudiant";
            this.prenom_etudiant.Size = new System.Drawing.Size(100, 20);
            this.prenom_etudiant.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nom  :";
            // 
            // nom_etudiant
            // 
            this.nom_etudiant.Location = new System.Drawing.Point(120, 52);
            this.nom_etudiant.Name = "nom_etudiant";
            this.nom_etudiant.Size = new System.Drawing.Size(100, 20);
            this.nom_etudiant.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "CNE :";
            // 
            // cne_etudiant
            // 
            this.cne_etudiant.Location = new System.Drawing.Point(120, 19);
            this.cne_etudiant.Name = "cne_etudiant";
            this.cne_etudiant.Size = new System.Drawing.Size(100, 20);
            this.cne_etudiant.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Chercher un étudiant :";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.etudiant_stat);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(725, 451);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Statistique";
            // 
            // etudiant_stat
            // 
            chartArea3.Name = "ChartArea1";
            this.etudiant_stat.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend11";
            this.etudiant_stat.Legends.Add(legend3);
            this.etudiant_stat.Location = new System.Drawing.Point(30, 112);
            this.etudiant_stat.Name = "etudiant_stat";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend11";
            series3.Name = "NombreEtudiants";
            this.etudiant_stat.Series.Add(series3);
            this.etudiant_stat.Size = new System.Drawing.Size(653, 315);
            this.etudiant_stat.TabIndex = 0;
            this.etudiant_stat.Text = "chart1";
            // 
            // tabPage4
            // 
            this.tabPage4.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.tabPage4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tabPage4.Controls.Add(this.reportViewer1);
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Controls.Add(this.panel3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(725, 451);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Reporting";
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet2";
            reportDataSource3.Value = this.FiliereBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.UsersInfoRPT.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 155);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(710, 290);
            this.reportViewer1.TabIndex = 3;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.CneTextBox);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.AfficherCne);
            this.panel4.Location = new System.Drawing.Point(390, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 100);
            this.panel4.TabIndex = 2;
            // 
            // CneTextBox
            // 
            this.CneTextBox.Location = new System.Drawing.Point(129, 17);
            this.CneTextBox.Name = "CneTextBox";
            this.CneTextBox.Size = new System.Drawing.Size(100, 20);
            this.CneTextBox.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Saisir un CNE :";
            // 
            // AfficherCne
            // 
            this.AfficherCne.Location = new System.Drawing.Point(89, 57);
            this.AfficherCne.Name = "AfficherCne";
            this.AfficherCne.Size = new System.Drawing.Size(75, 23);
            this.AfficherCne.TabIndex = 0;
            this.AfficherCne.Text = "Afficher";
            this.AfficherCne.UseVisualStyleBackColor = true;
            this.AfficherCne.Click += new System.EventHandler(this.AfficherCne_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.AfficherTous);
            this.panel3.Location = new System.Drawing.Point(47, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Tous Les étudiants";
            // 
            // AfficherTous
            // 
            this.AfficherTous.Location = new System.Drawing.Point(56, 57);
            this.AfficherTous.Name = "AfficherTous";
            this.AfficherTous.Size = new System.Drawing.Size(75, 23);
            this.AfficherTous.TabIndex = 0;
            this.AfficherTous.Text = "Afficher";
            this.AfficherTous.UseVisualStyleBackColor = true;
            this.AfficherTous.Click += new System.EventHandler(this.AfficherTous_Click);
            // 
            // FiliereTableAdapter
            // 
            this.FiliereTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(228, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(295, 20);
            this.label14.TabIndex = 11;
            this.label14.Text = "Le Nombre des étudiants par Filiére";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 480);
            this.Controls.Add(this.statistic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FiliereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            this.statistic.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.etudiant_stat)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl statistic;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button remove_filiere;
        private System.Windows.Forms.Button mod_filiere;
        private System.Windows.Forms.Button ajouter_filiere;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nom_filiere;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button tri_decroiss;
        private System.Windows.Forms.Button tri_croiss;
        private System.Windows.Forms.Button charger_etd;
        private System.Windows.Forms.Button import_data;
        private System.Windows.Forms.Button supprimer_etd;
        private System.Windows.Forms.Button modifier_etd;
        private System.Windows.Forms.Button ajouter_etd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox list_filiere;
        private System.Windows.Forms.CheckBox check_F;
        private System.Windows.Forms.CheckBox check_Homme;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tele_etudiant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adresse_etudiant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prenom_etudiant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nom_etudiant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cne_etudiant;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart etudiant_stat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textfiliere_mod;
        private System.Windows.Forms.Button valid_filiere;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Button sheet;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ComboBox cboSheet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox CneTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button AfficherCne;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button AfficherTous;
        private System.Windows.Forms.Button button2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FiliereBindingSource;
        private DataSet2 DataSet2;
        private DataSet2TableAdapters.FiliereTableAdapter FiliereTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

