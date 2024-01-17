using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBDD
{
    internal class ClassInstitutBD
    {
        SqlConnection con = new SqlConnection();
        // Representation une connexion ouvere a une base de donnees
        DataTable dt = new DataTable();
        // Represente une table de donnees en memoire
        SqlCommand com = new SqlCommand();
        // represente des requetes SQL ou des procedures stockees
        SqlDataAdapter Sda = new SqlDataAdapter();
        DataSet ds = new DataSet();
        private void Connecter()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.ConnectionString = @"Data Source=HOME;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
                    con.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the database: " + ex.Message);
            }
        }
        private void Deconnecter()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public void remplireGV(DataGridView dgv, string reqSgl)
        {
            try
            {
                dt.Clear();
                Connecter();
                com.Connection = con;
                com.CommandText = reqSgl;
                Sda.SelectCommand = com;
                Sda.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Deconnecter();
            }

        }
        public void insererEmploye(Model_Emp emp) 
        {
            Connecter();
            using (SqlCommand cmd = new SqlCommand("INSERT INTO [ITEEM].[dbo].[Etudiant]\r\n VALUES (@Mat, @Nom, @Prenom, @Sexe, @dateNaiss)", con))
            {
                string nom = emp.NomEmp;
                string Prenom = emp.PrenomEmp;
                string Date = emp.DnEmp.ToString();
                string Mat = emp.Mat.ToString();
                string Sex = emp.SexeEmp.ToString();
                string tot = Sex + Mat + Date + Prenom + nom;
                MessageBox.Show(tot);
                cmd.Parameters.AddWithValue("@Nom", emp.NomEmp);
                cmd.Parameters.AddWithValue("@Prenom", emp.PrenomEmp);
                cmd.Parameters.AddWithValue("@dateNaiss", emp.DnEmp.Date);
                cmd.Parameters.AddWithValue("@Mat", emp.Mat);
                cmd.Parameters.AddWithValue("@Sexe", emp.SexeEmp);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {

                    DialogResult result= MessageBox.Show("cette structure n'existe pas, souhaitez-vous ajouter une nouvelle structure","struct Error",MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (result== DialogResult.Yes)
                    {

                    }
                }
                
            }
            Deconnecter();
        }

        public void Edit_emp()
        {

            Connecter();
            // Use a SqlCommandBuilder to automatically generate the update command
            using (SqlCommandBuilder commandBuilder = new SqlCommandBuilder(Sda))
            {
                // Update the database with changes
                Sda.Update(dt);
            }
            Deconnecter();
        }
        public void Delete_Emp(string ID)
        {
            Connecter();
            String query = $"DELETE fROM [ITEEM].[dbo].[Etudiant]\r\n" +
                $" WHERE IdEmp = {ID}";
            MessageBox.Show(query);

            com.CommandText = query;

           com.ExecuteNonQuery();
            Deconnecter();
        }

    }
}

