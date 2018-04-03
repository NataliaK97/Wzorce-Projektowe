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
    public partial class Form2 : Form
    {
        Interface factoryInt = null;
        Form1 form1 = null;

        public Form2(Form1 form1, Interface fc)
        {
            InitializeComponent();
            this.form1 = form1;
            factoryInt = fc;
        }


        private void addButon_Click(object sender, EventArgs e)
        {
            if (factoryInt.AddItem(textBoxNewName.Text))
                textBoxNewName.Text = "";
            
        }

        private void cancelButon_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                this.Close();
                factoryInt.Load();
                form1.CopyGridView(factoryInt.DataList, form1.dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxNewName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
