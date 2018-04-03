using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BazaApp
{
    class Connect
        {
            static MySqlConnection baseConnection;
            static MySqlCommand baseCommand;

            public static MySqlCommand CommandDatabase { get => baseCommand; }
            public static MySqlConnection DatabaseConnection { get => baseConnection; }

            public static int ExecuteNonQuery(){
                return CommandDatabase.ExecuteNonQuery();
            }

            public static MySqlDataReader ExecuteReader(){
                return CommandDatabase.ExecuteReader();
            }

            public static void OpenDB(){
                DatabaseConnection.Open();
            }

            public static void CloseDB(){
                DatabaseConnection.Close();
            }

            public static void ConnectToDB(){
            baseConnection = new MySqlConnection("Host=127.0.0.1;Port=3306;user id=root;Password=;database=mydb");
            }

            public static void CommandDB(string query){
            baseCommand = new MySqlCommand(query, DatabaseConnection){
                CommandTimeout = 90};
            }

            public static bool DataToFactoryClass(Interface factoryInt, string sort = null){
                bool result = false;

                ConnectToDB();
                CommandDB("SELECT * FROM " + factoryInt.TableName + sort);

                try {
                    OpenDB();
                    MySqlDataReader readerr = ExecuteReader();

                    if (readerr.HasRows)
                    {
                        factoryInt.DataList.Rows.Clear();
                        result = true;

                        while (readerr.Read())
                        {
                            ListViewItem newItem = new ListViewItem(readerr.GetString(0));
                            newItem.SubItems.Add(readerr.GetString(1));
                        factoryInt.DataList.Rows.Add(newItem);
                        }
                    }
                    else
                    {
                        result = false;
                        throw new Exception("Baza jest pusta");
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("Podane dane są nieprawodłowe");
                }
                finally {
                    CloseDB();
                }
                return result;
            }
        }
    }
