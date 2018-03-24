using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazaApp
{
    public partial class Form1 : Form
    {
        bool sort = true;

        public void delMenu()
        {
            numericUpDown1.Visible = !numericUpDown1.Visible;
            delButton2.Visible = !delButton2.Visible;
        }
        public void addMenu()
        {
            textBox1.Visible = !textBox1.Visible;
            addButton2.Visible = !addButton2.Visible;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Visible == true)
            {
                delMenu();
            }
            addMenu();
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible==true)
            {
                addMenu();
            }
            delMenu();
        }

        private void sortButton1_Click(object sender, EventArgs e)
        {
            if (sort==true)
            {
                listView1.Sorting = SortOrder.Ascending;
                sort = false;
            }
            else
            {
                listView1.Sorting = SortOrder.Descending;
                sort = true;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            addMenu();
            delMenu();

            ListViewItem item1 = new ListViewItem("Przykład1");
            ListViewItem item2 = new ListViewItem("Przykład2");
            ListViewItem item3 = new ListViewItem("Przykład3");
            ListViewItem item4 = new ListViewItem("Przykład4");

            listView1.Items.Add(item1);
            listView1.Items.Add(item2);
            listView1.Items.Add(item3);
            listView1.Items.Add(item4);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //potwierdż dodanie
        }

        private void delButton2_Click(object sender, EventArgs e)
        {
            //potwierdź usunięcie
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //tekst dodanego
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //index usuwanego
        }
    }
}
