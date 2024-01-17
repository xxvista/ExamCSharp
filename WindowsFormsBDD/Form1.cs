using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBDD
{
    public partial class Form1 : Form
    {
        char selectedChar = ' ';

        private Dictionary<char, string> charDictionary = new Dictionary<char, string>();
        public Form1()
        {
            InitializeComponent();
            dgvEmployes.SetBounds(0, 224, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height - 300);

            // Populate the ComboBox with items
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");

            // Associate each item with a char value
            charDictionary.Add('1', "Male");
            charDictionary.Add('2', "Female");
        }

        ClassInstitutBD cibd = new ClassInstitutBD();
        private void Form1_Load(object sender, EventArgs e)
        {
            cibd.remplireGV(dgvEmployes, "SELECT * FROM [ITEEM].[dbo].[Etudiant]\r\n");
        }



        private void button1_Click(object sender, EventArgs e) // btn ajouter
        {
            if (FormProcces.verifierTbInPanel(panel1))
            {
                MessageBox.Show("verifier les champs");
            }
            else
            {
            

        }
            if (comboBox1.SelectedIndex != -1)
            {
                foreach (var pair in charDictionary)
                {
                    if (pair.Value == comboBox1.SelectedItem.ToString())
                    {
                        selectedChar = pair.Key;
                    }
                }
            }
            

                Model_Emp emp = new Model_Emp(
                    textBoxNom.Text,
                    textBoxPrenom.Text,
                    dateTimePickerDN.Value,
                    tb_struct.Text,
                    selectedChar
                  );
                cibd.insererEmploye(emp);
                FormProcces.viderPanel(panel1);
                dateTimePickerDN.Value = DateTime.Now;
                cibd.remplireGV(dgvEmployes, "SELECT * FROM [ITEEM].[dbo].[Etudiant]\r\n");
            }
        }


}
