using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BazaApp
{
    public static class Connect
    {
        static MySqlConnection baseConnection;
        static MySqlCommand baseCommand;
        public static MySqlCommand CommandDataBase { get => baseCommand; }
        public static MySqlConnection DataBaseConnection { get => baseConnection; }

        public static int ExecuteNonQuery() {
            return CommandDataBase.ExecuteNonQuery();
        }

        public static MySqlDataReader ExecuteReader() {
            return CommandDataBase.ExecuteReader();
        }

        public static void OpenDB() {
            DataBaseConnection.Open();
        }

        public static void CloseDB() {
            DataBaseConnection.Close();
        }
        public static bool DataToFactoryClass(Interface factoryInt, string sort = null) {
            bool r = false;
            ConnectBase();
            CommandBase("SELECT * FROM " + factoryInt.TableName + sort);
            //string query = "SELECT * FROM " + factoryInt.TableName + sort;

            try {
                //DataTable table = new DataTable();
                OpenDB();
                MySqlDataReader readerr = ExecuteReader();
                //MySqlDataAdapter adapter = new MySqlDataAdapter(query, baseConnection);
                if (readerr.HasRows)
                {
                    factoryInt.MyListView.Items.Clear();
                    r = true;
                    while (readerr.Read())
                    {
                        ListViewItem newItem = new ListViewItem(readerr.GetString(0));
                        newItem.SubItems.Add(readerr.GetString(1));
                        factoryInt.MyListView.Items.Add(newItem);
                    }

                    //DataGridView newItem=null;
                    // = new DataGridView(readerr.GetString(0));
                    //newItem.DataSource.Add(readerr.GetString(1));
                    //factoryInt.DataList.Rows.Add(newItem);
                    //adapter.Fill(table);
                    //newItem.DataSource = factoryInt.DataList;
                    //newItem.AutoResizeColumns();
                }
                else
                {
                    r = false;
                }
             }
            catch (Exception ex) {
                MessageBox.Show("Baza jest pusta! lub format danych nieprawidłowy");
             }
            finally {
                CloseDB();
            }
            return r;
        }
    
        public static void ConnectBase() {
            baseConnection = new MySqlConnection("Host=127.0.0.1;Port=3306;user id=root;Password=;database=mydb");
        }

        public static void CommandBase(string query) {
            baseCommand = new MySqlCommand(query, DataBaseConnection) {
                CommandTimeout = 90 };
        }
    }
}
