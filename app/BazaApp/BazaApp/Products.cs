using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BazaApp
{
    class Products : Interface
    {
        ListView myListView;
        bool sort = false;
        public string tableName = "products";
        public string idRow = "id_product";
        public string nameRow = "name";

        public ListView MyListView { get => myListView; }
        public string TableName { get => tableName; }
        public string IdRow { get => idRow; }
        public string NameRow { get => nameRow; }
        public bool Sort { get => sort; }


        //private static string stringConnection = "Host=127.0.0.1;Port=3306;user id=root;Password=;database=mydb";
        //private MySqlConnection baseConnection = new MySqlConnection(stringConnection);

        public Products()
        {
            myListView = new ListView();

        }
        /*private void ShowTable(string showList)
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
        public bool DeleteItem(string number)
        {
            bool r = false;
            try
            {
                Connect.ConnectBase();
                Connect.CommandBase("DELETE FROM products WHERE id_product =" + number);
                Connect.OpenDB();
                int deleter = Connect.ExecuteNonQuery();
                if (deleter == 0)
                    throw new Exception("Brak rekordu");
                else
                {
                    r = true;
                    MessageBox.Show("Usuwanie zakończone powidzeniem");
                }
            }
            catch (Exception ex)
            {
                r = false;
                MessageBox.Show("Błąd usuwania");
            }
            finally
            {
                if (Connect.DataBaseConnection != null)
                    if (Connect.DataBaseConnection.State == ConnectionState.Open)
                        Connect.CloseDB();
            }
            return r;
        }

        bool Interface.AddItem(string str)
        {
            bool r = false;
            Connect.ConnectBase();
            Connect.CommandBase("INSERT INTO products (name)  VALUES ('" + str + "');");

            try
            {
                Connect.OpenDB();
                int isAdd = Connect.ExecuteNonQuery();
                if (isAdd == 0)
                {
                    throw new Exception("Bład dodawania");
                }
                else
                {
                    r = true;
                    MessageBox.Show("Dodawanie zakończone powodzeniem");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dodawanie nie powiodło sie");
            }
            finally
            {
                Connect.CloseDB();
            }
            return r;
        }

        void Interface.NameSort()
        {

            if (sort == false)
            {
                Connect.DataToFactoryClass(this, " ORDER BY name DESC");
                sort = true;
            }
            else
            {
                Connect.DataToFactoryClass(this, " ORDER BY name ASC");
                sort = false;
            }

        }

        void Interface.Load(string orderBy)
        {
            Connect.DataToFactoryClass(this, orderBy);
        }
    }
}
