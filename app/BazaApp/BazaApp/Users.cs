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
    class Users : Interface
    {
        ListView myListView;
        bool sort = false;
        public string tableName = "users";
        public string idRow = "id_user";
        public string nameRow = "name";

        public ListView MyListView { get => myListView; }
        public string TableName { get => tableName; }
        public string IdRow { get => idRow; }
        public string NameRow { get => nameRow; }
        public bool Sort { get => sort; }

        public Users()
        {
            myListView = new ListView();

        }
        
        public bool DeleteItem(string number)
        {
            bool r = false;
            try {
                universalFunctions.ConnectBase();
                universalFunctions.CommandBase("DELETE FROM users WHERE id_user =" + number);
                universalFunctions.OpenDB();
                int deleter = universalFunctions.ExecuteNonQuery();
                if (deleter == 0)
                    throw new Exception("Brak rekordu");
                else {
                    r = true;
                    MessageBox.Show("Usuwanie zakończone powidzeniem");
                }
            }
            catch (Exception ex) {
                r = false;
                MessageBox.Show("Błąd usuwania");
            }
            finally {
                if (universalFunctions.DataBaseConnection != null)
                    if (universalFunctions.DataBaseConnection.State == ConnectionState.Open)
                        universalFunctions.CloseDB();
            }
            return r;
        }
    
        bool Interface.AddItem(string str)
        {
            bool r = false;
            universalFunctions.ConnectBase();
            universalFunctions.CommandBase("INSERT INTO users (name) VALUES ('" + str + "');");

            try {
                universalFunctions.OpenDB();
                int isAdd = universalFunctions.ExecuteNonQuery();
                if (isAdd == 0) {
                    throw new Exception("Bład dodawania");
                }
                else {
                    r = true;
                    MessageBox.Show("Dodawanie zakończone powodzeniem");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Dodawanie nie powiodło sie");
            }
            finally {
                universalFunctions.CloseDB();
            }
            return r;
        }

        void Interface.NameSort()
        {

            if (sort == false)
            {
                universalFunctions.DataToFactoryClass(this, " ORDER BY name DESC");
                sort = true;
            }
            else
            {
                universalFunctions.DataToFactoryClass(this, " ORDER BY name ASC");
                sort = false;
            }

        }

        void Interface.Load(string orderBy) {
            universalFunctions.DataToFactoryClass(this, orderBy);
        }
    }
}
