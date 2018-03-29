using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BazaApp
{
    public partial class Form2 : Form
    {
        private static string stringConnection = "Host=127.0.0.1;Port=3306;user id=root;Password=;database=mydb";
        private MySqlConnection baseConnection = new MySqlConnection(stringConnection);
        public Form2()
        {
            InitializeComponent();
        }

        private void addButon_Click(object sender, EventArgs e)
        {
            string addName = textBoxNewName.Text;

            if (string.IsNullOrEmpty(addName))
            {
                MessageBox.Show("Nie uzupełniłeś pola nazwą użytkownika.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (addName.Length > 65)
            {
                MessageBox.Show("Podana nazwa jest za długa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = $"INSERT INTO users (name) VALUES ('{addName}');";
            MySqlCommand commandDatabase = new MySqlCommand(query, baseConnection);
            commandDatabase.CommandTimeout = 90;

            try
            {
                baseConnection.Open();
                commandDatabase.ExecuteReader();
                MessageBox.Show("Operacja dodawania zakończona powodzeniem :)");
                baseConnection.Close();
                textBoxNewName.Text = string.Empty;
                this.Hide();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelButon_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
