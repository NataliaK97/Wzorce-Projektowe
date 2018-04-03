﻿using System;
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
        DataGridView gridView;
        bool sortOrder = false;
        bool sort = false;

        public DataGridView DataList { get => gridView; }

        public string TableName { get => "users"; }

        public string IdRowName { get => "id_user"; }

        public string NameRowName { get => "name"; }

        public bool DeleteItem(int index)
        {
            bool result = false;
            try {
                Connect.ConnectToDB();
                Connect.CommandDB("DELETE FROM users WHERE Id_user = {index};");
                Connect.OpenDB();
                int deleter = Connect.ExecuteNonQuery();
                if (deleter == 0)
                    throw new Exception("Brak rekordu");
                else {
                    result = true;
                }
            }
            catch (Exception ex) {
                result = false;
                MessageBox.Show("Błąd usuwania");
            }
            finally {
                if (Connect.DatabaseConnection != null)
                    if (Connect.DatabaseConnection.State == ConnectionState.Open)
                        Connect.CloseDB();
            }
            return result;
        }
    
        bool Interface.AddItem(string name)
        {
            bool result = false;
            Connect.ConnectToDB();
            Connect.CommandDB("INSERT INTO users (name) VALUES ('{name}');");

            try {
                Connect.OpenDB();
                int isAdd = Connect.ExecuteNonQuery();
                if (isAdd == 0)
                {
                    throw new Exception("Bład dodawania");
                }
                else
                {
                    result = true;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Dodawanie nie powiodło sie");
            }
            finally {
                Connect.CloseDB();
            }
            return result;
        }

        void Interface.SortItemsOverName()
        {
            if (sort == true)
            {
                Connect.DataToFactoryClass(this, "ORDER BY users.name ASC");
                
                sort = false;
            }
            else
            {
                Connect.DataToFactoryClass(this, "ORDER BY users.name DESC");
                //ShowTable(tekst);
                sort = true;
            }
        }

        void Interface.Load(string orderBy)
        {
            Connect.DataToFactoryClass(this, orderBy);
        }
    }
}
