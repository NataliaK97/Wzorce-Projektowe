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
        Interface interfaceFact = null;

       // private static string stringConnection = "Host=127.0.0.1;Port=3306;user id=root;Password=;database=mydb";
       // private MySqlConnection baseConnection = new MySqlConnection(stringConnection);

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Użytkownicy");
            comboBox1.Items.Add("Produkty");
            comboBox1.Items.Add("Uprawnienia");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem == null)
                    throw new Exception("Wybierz jedną z tabel");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
                return;
            }

            Form2 form2 = new Form2(this, interfaceFact);
            form2.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedItem == null)
                MessageBox.Show("Wybierz jedną z tabel");
            
            if (dataGridView1.SelectedRows.Count == 0 || dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Nie wybrano pozycji do usunięcia");
                return;
            }
            int dellThis;
            try
            {
               dellThis = dataGridView1.SelectedRows[0].Index;
            }
            catch (Exception)
            {
                MessageBox.Show("Wybierz rekord!");
                return;
            }
            interfaceFact.DeleteItem(dellThis);
        }

        private void sortButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem == null)
                    throw new Exception("Wybierz jedną z tabel");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
                return;
            }

            interfaceFact.SortItemsOverName();
            CopyGridView(interfaceFact.DataList, dataGridView1);
            label1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       /* private void ShowTable(string showList)
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
        }*/

        private void get_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem == null)
                    throw new Exception("Wybierz jedną z dostępnych tabel!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
                return;
            }
            interfaceFact.Load();
            CopyGridView(interfaceFact.DataList, dataGridView1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string classs = comboBox1.SelectedItem.ToString();
            interfaceFact = Factory.Lista(classs);

            //listView1.Columns[0].Text = factoryInt.IdRowName;
            //listView1.Columns[1].Text = factoryInt.NameRowName;

            try
            {
                if (comboBox1.SelectedItem == null)
                    throw new Exception("Wybierz tabelę z listy!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Pobiernie danych z bazy nie powiodło się! Błąd: " + ex.Message);
                return;
            }

            interfaceFact.Load();

            CopyGridView(interfaceFact.DataList, dataGridView1);
        }
        
        ////////////////////////////////////////
        
        public void CopyGridView(DataGridView source, DataGridView destination)
        {
            destination.Rows.Clear();

            foreach (DataGridViewRow row in source.Rows)
                destination.Rows.Add((DataGridViewRow)row.Clone());
        }

        void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
