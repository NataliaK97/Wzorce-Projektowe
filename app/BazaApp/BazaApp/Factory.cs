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
    public partial class Factory : Form
    {
            public static Interface Lista(string classs)
            {
                try
                {
                if (classs == "Uprawnienia")
                    return new Privileges();
                if (classs == "Użytkownicy")
                        return new Users();
                if (classs == "Produkty")
                    return new Products();
                throw new NotImplementedException();
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd: " + ex.Message);
                    return null;
                }
            }

            private void InitializeComponent()
            {
            this.SuspendLayout();
            // 
            // Factory
            // 
            this.ClientSize = new System.Drawing.Size(778, 394);
            this.Name = "Factory";
            this.Load += new System.EventHandler(this.Factory_Load);
            this.ResumeLayout(false);

            }

            private void Factory_Load(object sender, EventArgs e)
            {

            }
        }
    }
