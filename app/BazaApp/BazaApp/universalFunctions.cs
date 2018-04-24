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
    
    public class universalFunctions
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

        // do memento
        private String text;
        public universalFunctions(String thisText)
        {
            this.text = thisText;
        }
        public universalFunctions()
        {
            this.text = "";
        }
        public universalFunctions(String id, String name, String table)
        {
            String commit;
            commit = "id:" + id + "/name:" + name + "/table:" + table + "/";
            this.text = commit;
        }
        public String[] getText()
        {
            int number = 0;
            string[] titles = new string[3]
            {
                "id:","name:","table:"
            };
            string isGood = "";
            string[] split = new string[3]
            {
                "","",""
            };
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (isGood.Equals(titles[number]))
                {
                    if (text[i] != '/')
                        split[number] += text[i];
                    else
                    {
                        number++;
                        isGood = "";
                    }
                }
                else
                    isGood += text[i];
            }
            return split;
        }

        public void setText(String id, String name, String table)
        {
            String commit;
            commit = "id:" + id + "/name:" + name + "/table:" + table + "/";
            this.text = commit;
        }

        public Memento createMemento()
        {
            return new Memento(this.text);
        }

        public void renewMemento(Memento memento)
        {
            try
            {
                this.text = memento.getText();
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
