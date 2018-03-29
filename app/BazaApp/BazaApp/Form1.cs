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

        public Form1()
        {
            InitializeComponent();
            //ShowTable(string.Empty);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
        }

        private void sortButton1_Click(object sender, EventArgs e)
        {
            
            if (sort==true)
            {
                string tekst = "ORDER BY users.name ASC";
                ShowTable(tekst);
                sort = false;
            }
            else
            {
                string tekst = "ORDER BY users.name DESC";
                ShowTable(tekst);
                sort = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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
            ShowTable(string.Empty);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
