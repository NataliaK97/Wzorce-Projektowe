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

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
