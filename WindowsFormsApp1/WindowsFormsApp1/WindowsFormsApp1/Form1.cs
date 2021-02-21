using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExcelDataReader;
using System.IO;
using Z.Dapper.Plus;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DataSet2 DataSetGridView = new DataSet2();
        Microsoft.Reporting.WinForms.ReportDataSource ReportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
        System.Windows.Forms.BindingSource bs1 = new System.Windows.Forms.BindingSource();

        public int studientID;
        
        public int total_filiere;
        int id_filiere_etudiant;
        public int total_etudiant = 0;
        public int total_etudiant_par_filiere = 0;
        public int stat_par_filiere; // Data Source=DESKTOP-2DIVA41\\SQL_PROJECT; Initial Catalog=student_management; User Id=sa; Password=hamza1999; Integrated Security =true
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-MUMHPSL\\SQLEXPRESS;Initial Catalog=student_management;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        void loadSubreport(Object sender, SubreportProcessingEventArgs e)
        {
            e.DataSources.Add(new ReportDataSource("DataSet2" ,bs1));
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'DataSet2.Filiere'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.FiliereTableAdapter.Fill(this.DataSet2.Filiere);
            affiche_filiere();
            charger_filiere();
            charger_diagram();
            

            this.FiliereTableAdapter.Fill(this.DataSet2.Filiere);
            bs1.DataMember = "etudiant";
            bs1.DataSource = DataSetGridView;
            DataSet2TableAdapters.etudiantTableAdapter cstp = new DataSet2TableAdapters.etudiantTableAdapter();
            cstp.Fill(this.DataSetGridView.etudiant);

            reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(loadSubreport);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        /*------------------------------------------- espace  Filiere ---------------------------------------------*/
        // Ajouter Filiere
        private void ajouter_filiere_Click(object sender, EventArgs e)
        {
            if (nom_filiere.Text.Trim().Length != 0)
            {
                con.Open();



                SqlCommand cmd = new SqlCommand("INSERT INTO Filiere(Nom_filiere) VALUES (@nom_filiere)", con);
                cmd.Parameters.AddWithValue("@nom_filiere", nom_filiere.Text);


                cmd.ExecuteNonQuery();
                con.Close();

                nom_filiere.Text = "";
                affiche_filiere();
                charger_filiere();
                MessageBox.Show("Successfully Inserted!!");
            }
            else
            {
                MessageBox.Show("S'il vous plait entrez une filiere !");
            }
        }
        // Remplire Table des filiere
        private void affiche_filiere()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Filiere", con);
            DataTable dt = new DataTable();
            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridView1.DataSource = dt;
        }

        private void mod_filiere_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                panel1.Visible = true;
            } else
            {
                MessageBox.Show("Selectionnez une ligne!!!");
            }
        }

        // modifier une filiere
        private void valid_filiere_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand Updatecmd = new SqlCommand("UPDATE Filiere SET Nom_filiere=@Nom_filiere WHERE Id_filiere = @Id_filiere", con);
            Updatecmd.Parameters.AddWithValue("@Nom_filiere", textfiliere_mod.Text);
            Updatecmd.Parameters.AddWithValue("@id_filiere", Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));

            Updatecmd.ExecuteNonQuery();
            con.Close();

            textfiliere_mod.Text = "";
            panel1.Visible = false;

            affiche_filiere();
            charger_filiere();

            MessageBox.Show("Successfully Updated!!!");
        }
        // Supprimer filiere
        private void remove_filiere_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string msg = "Vous voulez supprimer la filiere " + dataGridView1.SelectedRows[0].Cells[1].Value + " ? ";
                var confirm = MessageBox.Show(msg, "", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    con.Open();

                    SqlCommand deleteCmd = new SqlCommand("DELETE FROM Filiere where  Id_Filiere = @Id_Filiere", con);
                    deleteCmd.Parameters.AddWithValue("@Id_Filiere", Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                    deleteCmd.ExecuteNonQuery();
                    con.Close();

                    affiche_filiere();
                    charger_filiere();
                }
            }
            else
            {
                MessageBox.Show("Selectionnez une ligne!!!");
            }
        }



        /*--------------------------------------------- espace etudiant -----------------------------------------------*/

        private void ajouter_etd_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                con.Open();



                SqlCommand insertCmd = new SqlCommand("INSERT INTO etudiant(cne, nom, prenom, sexe, date_naiss, adresse, teleph, filieres) VALUES (@cne, @nom, @prenom, @sexe, @date_naiss, @adresse, @teleph, @filieres)", con);
                insertCmd.Parameters.AddWithValue("@cne", Convert.ToInt32(cne_etudiant.Text));
                insertCmd.Parameters.AddWithValue("@nom", nom_etudiant.Text);
                insertCmd.Parameters.AddWithValue("@prenom", prenom_etudiant.Text);
                if (check_F.Checked)
                {
                    insertCmd.Parameters.AddWithValue("@sexe", check_F.Text);
                }
                else
                {
                    insertCmd.Parameters.AddWithValue("@sexe", check_Homme.Text);
                }

                insertCmd.Parameters.AddWithValue("@date_naiss", dateTimePicker1.Text);
                insertCmd.Parameters.AddWithValue("@adresse", adresse_etudiant.Text);
                insertCmd.Parameters.AddWithValue("@teleph", Convert.ToInt32(tele_etudiant.Text));
                insertCmd.Parameters.AddWithValue("@filieres", list_filiere.SelectedItem.ToString());


                insertCmd.ExecuteNonQuery();
                con.Close();

                nom_etudiant.Text = "";
                prenom_etudiant.Text = "";
                cne_etudiant.Text = "";
                tele_etudiant.Text = "";
                adresse_etudiant.Text = "";
                charger_diagram();

                MessageBox.Show("Successfully Inserted!!");

            }
            else
            {
                MessageBox.Show("S'il vous plais remplir tout les field demandées");
            }
        }

        private bool isValid()
        {
            if (cne_etudiant.Text.Length == 0 ||
                nom_etudiant.Text.Length == 0 ||
                prenom_etudiant.Text.Length == 0 ||
                adresse_etudiant.Text.Length == 0 ||
                tele_etudiant.Text.Length == 0 || (!check_F.Checked && !check_Homme.Checked)
            ) {
                return false;
            }
            return true;
        }


        private void charger_etd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM etudiant", con);
            DataTable dt = new DataTable();           

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridView2.DataSource = dt;
        }

        private void tri_croiss_Click(object sender, EventArgs e)
        {
            dataGridView2.Sort(dataGridView2.Columns[1], ListSortDirection.Ascending);
        }

        private void tri_decroiss_Click(object sender, EventArgs e)
        {
            dataGridView2.Sort(dataGridView2.Columns[1], ListSortDirection.Descending);
        }

        private void modifier_etd_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                con.Open();
                SqlCommand Updatecmd = new SqlCommand("UPDATE etudiant SET nom=@nom, prenom=@prenom, sexe=@sexe, date_naiss=@date_naiss, adresse=@adresse, teleph=@teleph, filieres=@filieres WHERE cne=@cne", con);
                Updatecmd.Parameters.AddWithValue("@nom", nom_etudiant.Text);
                Updatecmd.Parameters.AddWithValue("@prenom", prenom_etudiant.Text);
                if (check_F.Checked)
                {
                    Updatecmd.Parameters.AddWithValue("@sexe", check_F.Text);
                }
                else
                {
                    Updatecmd.Parameters.AddWithValue("@sexe", check_Homme.Text);
                }
                Updatecmd.Parameters.AddWithValue("@date_naiss", dateTimePicker1.Text);
                Updatecmd.Parameters.AddWithValue("@adresse", adresse_etudiant.Text);
                Updatecmd.Parameters.AddWithValue("@teleph", tele_etudiant.Text);
                Updatecmd.Parameters.AddWithValue("@filieres", list_filiere.SelectedItem.ToString());
                Updatecmd.Parameters.AddWithValue("@cne", Convert.ToInt32(cne_etudiant.Text));


                Updatecmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully Updated!!");
            }
            else
            {
                MessageBox.Show("S'il vous plais selectionnez un etudiant!!");
            }
        }

        private void selected_etd(object sender, DataGridViewCellEventArgs e)
        {
            cne_etudiant.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            nom_etudiant.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            prenom_etudiant.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            if(dataGridView2.SelectedRows[0].Cells[3].Value.ToString() == "M")
            {
                check_Homme.Checked = true;
            }
            else
            {
                check_F.Checked = true;
            }
            adresse_etudiant.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
            tele_etudiant.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
            list_filiere.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void supprimer_etd_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                string msg = "Vous voulez supprimer l'etudiant  " + dataGridView2.SelectedRows[0].Cells[1].Value + " ? ";
                var confirm = MessageBox.Show(msg, "", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    con.Open();

                    SqlCommand deleteCmd = new SqlCommand("DELETE FROM etudiant where  cne = @cne", con);
                    deleteCmd.Parameters.AddWithValue("@cne", Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value));
                    deleteCmd.ExecuteNonQuery();
                    con.Close();
                }
                charger_diagram();
            }
            else
            {
                MessageBox.Show("Selectionnez une ligne!!!");
            }
        }

        private void charger_filiere()
        {
            list_filiere.Items.Clear();
            con.Open();
            SqlCommand filieresCmd = new SqlCommand("SELECT * FROM Filiere", con);
            SqlDataReader filieres = filieresCmd.ExecuteReader();

            while (filieres.Read())
            {
                list_filiere.Items.Add(filieres[1]);
            }

            con.Close();

        }


        private void charger_diagram()
        {
            etudiant_stat.Series["NombreEtudiants"].Points.Clear();
            List<string> filiere_name = new List<string>();
            Dictionary<string, double> statistique = new Dictionary<string, double>();
            con.Open();
            SqlCommand filieresCmd = new SqlCommand("SELECT * FROM Filiere", con);
            SqlDataReader filieres = filieresCmd.ExecuteReader();

            while (filieres.Read())
            {
                filiere_name.Add(filieres[1].ToString());
            }

            con.Close();

            foreach(string f in filiere_name)
            {
                statistique.Add(f, nombre_etudiant(f));
            }

            foreach (KeyValuePair<string, double> entry in statistique)
            {
                etudiant_stat.Series["NombreEtudiants"].Points.AddXY(entry.Key, (entry.Value / (double)totalFiliere()) * 100);
            }
        }

        private int nombre_etudiant(string filiere)
        {
            con.Open();

            SqlCommand EtdCmd = new SqlCommand("SELECT COUNT(*) AS count FROM etudiant WHERE filieres=@nom_filiere", con);
            EtdCmd.Parameters.AddWithValue("@nom_filiere", filiere);
            SqlDataReader Etd = EtdCmd.ExecuteReader();

            while (Etd.Read())
            {
                total_etudiant_par_filiere = Convert.ToInt32(Etd[0]);
            }
            con.Close();

            return total_etudiant_par_filiere;
        }

        private int totalFiliere()
        {

            con.Open();
            SqlCommand EtdCmd = new SqlCommand("SELECT COUNT(*) AS total FROM etudiant", con);
            SqlDataReader Etd = EtdCmd.ExecuteReader();

            while (Etd.Read())
            {
                total_etudiant = Convert.ToInt32(Etd[0]);
            }
            con.Close();

            return total_etudiant;

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtFilename.Text = ofd.FileName;
                    using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true
                                }
                            });
                            tables = result.Tables;
                            cboSheet.Items.Clear();
                            foreach (DataTable table in tables)
                                cboSheet.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }

        private void sheet_Click(object sender, EventArgs e)
        {
            try
            {
                Insert(dataGridView3.DataSource as List<etudiant>);
                MessageBox.Show("Finished !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            panel2.Visible = false;
        }
        DataTableCollection tables;

        public void Insert(List<etudiant> list)
        {
            DapperPlusManager.Entity<etudiant>().Table("etudiant"); 
            using (IDbConnection db = new SqlConnection("Data Source=DESKTOP-MUMHPSL\\SQLEXPRESS;Initial Catalog=student_management;Integrated Security=True"))
            {
                db.BulkInsert(list);
            }
        }

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tables[cboSheet.SelectedItem.ToString()];
            if (dt != null)
            {
                List<etudiant> list = new List<etudiant>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    etudiant obj = new etudiant();
                    obj.cne = Convert.ToInt32(dt.Rows[i]["cne"].ToString());
                    obj.nom = dt.Rows[i]["nom"].ToString();
                    obj.prenom = dt.Rows[i]["prenom"].ToString();
                    obj.sexe = Convert.ToChar(dt.Rows[i]["sexe"]);
                    obj.date_naiss = dt.Rows[i]["date_naiss"].ToString();
                    obj.adresse = dt.Rows[i]["adresse"].ToString();
                    obj.teleph = Convert.ToInt32(dt.Rows[i]["teleph"]);
                    obj.filieres = dt.Rows[i]["filieres"].ToString();
                    
                    list.Add(obj);
                }
                dataGridView3.DataSource = list;
            }
        }

        private void import_data_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void AfficherTous_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-MUMHPSL\\SQLEXPRESS;Initial Catalog=student_management;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Filiere", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            ReportDataSource rds = new ReportDataSource("DataSet2", dt);

            reportViewer1.LocalReport.ReportPath = @"C:\Users\PC\Desktop\gestion-des-etudiants\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\UsersInfoRPT.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.Refresh();
        }

        private void AfficherCne_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-MUMHPSL\\SQLEXPRESS;Initial Catalog=student_management;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM etudiant WHERE cne=@cne", con);
            cmd.Parameters.AddWithValue("@cne", CneTextBox.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);

            reportViewer1.LocalReport.ReportPath = @"C:\Users\PC\Desktop\gestion-des-etudiants\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\UserInfoRPT.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.Refresh();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
