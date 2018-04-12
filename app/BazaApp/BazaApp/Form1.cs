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
        public string classs;


        //private static string stringConnection = "Host=127.0.0.1;Port=3306;user id=root;Password=;database=mydb";
        //private MySqlConnection baseConnection = new MySqlConnection(stringConnection);

        public Form1()
        {
            InitializeComponent();
            wybor.Items.Add("Użytkownicy");
            wybor.Items.Add("Produkty");
            wybor.Items.Add("Uprawnienia");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (wybor.SelectedItem == null)
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

            /*if (comboBox1.SelectedItem == null)
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
            interfaceFact.DeleteItem(dellThis);*/
            string dellThis=null;
            try {
                ListViewItem mylist = baza.SelectedItems[0];
                dellThis = mylist.SubItems[0].Text.ToString();
            }
            catch (Exception ex) {
                MessageBox.Show("Wybierz rekord do usunięcia!" );
                return;
            }
            if (interfaceFact.DeleteItem(dellThis))
            {
                interfaceFact.Load();
                CopyListView(interfaceFact.MyListView, baza);
            }
        }

        private void sortButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (wybor.SelectedItem == null)
                    throw new Exception("Wybierz jedną z tabel");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
                return;
            }
            finally
            {
                interfaceFact.NameSort();
                CopyListView(interfaceFact.MyListView, baza);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /*
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
        */

        private void get_Click(object sender, EventArgs e)
        {
            try {
                if (wybor.SelectedItem == null)
                    throw new Exception("Wybierz jedną z dostępnych tabel!");
            }

            catch (Exception ex) {
                MessageBox.Show("Błąd: " + ex.Message);
                return;
            }
            interfaceFact.Load();
            CopyListView(interfaceFact.MyListView, baza);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public int Choosen(string classs)
        {
            if (classs == "Użytkownicy")
                return 1;
            if (classs == "Uprawnienia")
                return 2;
            if (classs == "Produkty")
                return 3;
            else
                return 0;
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form2 f2=null;
            classs = wybor.SelectedItem.ToString();
            interfaceFact = Factory.Lista(classs);
            Choosen(classs);

            try
            {
                if (wybor.SelectedItem == null)
                    throw new Exception("Wybierz tabelę z listy!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Pobiernie danych z bazy nie powiodło się! Błąd: " + ex.Message);
                return;
            }

            interfaceFact.Load();

            CopyListView(interfaceFact.MyListView, baza);
        }

        public void CopyListView(ListView origin, ListView target) {
            target.Items.Clear();
            foreach (ListViewItem item in origin.Items)
            {
                target.Items.Add((ListViewItem)item.Clone());
            }
                
        }

    }
}
