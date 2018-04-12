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
        Interface interfaceFact = null;
        Form1 form1 = null;

        
        public Form2(Form1 form1, Interface fc)
        {
            InitializeComponent();
            interfaceFact = fc;
            this.form1 = form1;
            
            if (form1.Choosen(form1.classs) == 1)
            {
                title.Visible = true;
                titleU.Visible = false;
                titleP.Visible = false;
            }
            if (form1.Choosen(form1.classs) == 2)
            {
                title.Visible = false;
                titleU.Visible = true;
                titleP.Visible = false;
            }
            if (form1.Choosen(form1.classs) == 3)
            {
                title.Visible = false;
                titleU.Visible = false;
                titleP.Visible = true;
            }
            else
            {
                title.Visible = false;
                titleU.Visible = false;
                titleP.Visible = false;
            }

        }

        private void addButon_Click(object sender, EventArgs e)
        {
            if (interfaceFact.AddItem(textBoxNewName.Text) && textBoxNewName.Text != String.Empty)
                textBoxNewName.Text = "";
        }

        private void cancelButon_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                this.Close();
                interfaceFact.Load();
                form1.CopyListView(interfaceFact.MyListView, form1.baza);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxNewName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }
        private void title_load(object sender, EventArgs e)
        {
            
        }

        private void titleP_Click(object sender, EventArgs e)
        {

        }
    }
}
