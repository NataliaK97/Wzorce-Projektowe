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
        //bool sort = true;
        Interface interfaceFact = null;
        public string classs;
        Caretaker caretaker;
        universalFunctions creator;

        public Form1()
        {
            InitializeComponent();
            wybor.Items.Add("Użytkownicy");
            wybor.Items.Add("Produkty");
            wybor.Items.Add("Uprawnienia");
            caretaker = new Caretaker(this);
            creator = new universalFunctions();
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
            string id = null;
            string name = null;
            ListViewItem myList=null;
            try
            {
                myList = baza.SelectedItems[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie wybrono rokordu do usunięcia. Błąd:" + ex);
            }
            id = myList.SubItems[0].Text.ToString();
            name = myList.SubItems[1].Text.ToString();

            if (interfaceFact.DeleteItem(id))
            {
                creator.setText(id, name, interfaceFact.TableName);
                caretaker.AddMemento(creator.createMemento());
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

        private void get_Click(object sender, EventArgs e)
        {
            try
            {
                if (wybor.SelectedItem == null)
                    throw new Exception("Wybierz jedną z dostępnych tabel!");
            }

            catch (Exception ex)
            {
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
            //Form2 f2 = null;
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
                MessageBox.Show("Pobiernie danych z bazy nie powiodło się! Błąd: " + ex);
                return;
            }

            interfaceFact.Load();
            CopyListView(interfaceFact.MyListView, baza);
        }

        public void CopyListView(ListView origin, ListView target)
        {
            target.Items.Clear();
            foreach (ListViewItem item in origin.Items)
            {
                target.Items.Add((ListViewItem)item.Clone());
            }
        }

        private void renewButton_Click(object sender, EventArgs e)
        {
            if (Caretaker.stos>0)
            {
                creator.renewMemento(caretaker.GetMemento());
                string[] txt = new string[4];
                txt = creator.getText();

                string classs = "";
                if (txt[2].Equals("users"))
                    classs = "Użytkownicy";
                else if (txt[2].Equals("products"))
                    classs = "Produkty";
                else if (txt[2].Equals("privileges"))
                    classs = "Uprawnienia";

                if (Factory.classsName != classs)
                {
                    string lastCalasss = Factory.classsName;
                    interfaceFact = Factory.Lista(classs);
                    classs = lastCalasss;
                }
                try
                {
                    if (interfaceFact.AddItem(txt[1]))
                    {
                        if (Factory.classsName != wybor.SelectedItem.ToString())
                        {
                            interfaceFact = Factory.Lista(classs);
                        }
                        else
                        {
                            interfaceFact.Load();
                            CopyListView(interfaceFact.MyListView, baza);
                        }
                    }
                }
                catch (Exception ex) { }
            }
            else
                MessageBox.Show("Brak danych do przywrócenia!");
        }
    }
}
