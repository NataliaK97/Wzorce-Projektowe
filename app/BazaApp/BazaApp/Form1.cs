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
    public partial class Form1 : Form
    {
        bool sort = true;

        private static string stringConnection = "Host=127.0.0.1;Port=3306;user id=root;Password=;database=mydb";
        private MySqlConnection baseConnection = new MySqlConnection(stringConnection);

        
   
        public void delMenu()
        {
            delButton2.Visible = !delButton2.Visible;
            label3.Visible = !label3.Visible;
        }

        public void addMenu()
        {
            textBox1.Visible = !textBox1.Visible;
            addButton2.Visible = !addButton2.Visible;
            label2.Visible = !label2.Visible;
        }

        public Form1()
        {
            InitializeComponent();
            ShowTable(string.Empty);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (label3.Visible == true)
            {
                delMenu();
            }
            addMenu(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label2.Visible==true)
            {
                addMenu();
            }
            delMenu();
        }

        private void sortButton1_Click(object sender, EventArgs e)
        {
            
            if (sort==true)
            {
                string doczepka = "ORDER BY users.name ASC";
                ShowTable(doczepka);
                sort = false;
            }
            else
            {
                string doczepka = "ORDER BY users.name DESC";
                ShowTable(doczepka);
                sort = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addMenu();
            delMenu();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string addName = textBox1.Text;
            
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
                textBox1.Text = string.Empty;
                ShowTable(string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 || dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Nie wybrano pozycji do usunięcia");
                return;
            }

            int dellThis = dataGridView1.SelectedRows[0].Index;
            int id = int.Parse(dataGridView1.Rows[dellThis].Cells[0].Value.ToString());
            string query = $"DELETE FROM users WHERE Id_user = {id};";
            MySqlCommand commandDatabase = new MySqlCommand(query, baseConnection);
            commandDatabase.CommandTimeout = 90;

            try
            {
                baseConnection.Open();
                commandDatabase.ExecuteReader();
                MessageBox.Show("Operacja usuwania zakończona powodzeniem :)");
                baseConnection.Close();
                ShowTable(string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //tekst dodanego
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ShowTable(string showList)
        {
            try
            {
                DataTable table = new DataTable();
                string query = $"SELECT * FROM users {showList};";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, baseConnection);
                baseConnection.Open();

                adapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.AutoResizeColumns();

                baseConnection.Close();
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void get_Click(object sender, EventArgs e)
        {

        }
    }
}
