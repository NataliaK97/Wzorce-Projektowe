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
            public static Interface Lista(string className)
            {
                try
                {
                    if (className == "Użytkownicy")
                        return new Users();

                    if (className == "Produkty")
                        return new Products();

                    if (className == "Uprawnienia")
                        return new Privileges();

                    throw new Exception("Nie odnaleziono klasy do utworzenia!");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Nie udało się utworzyć klasy.\n\nTreśc błedu: " + exc.Message);
                    return null;
                }
            }

            private void InitializeComponent()
            {
                this.SuspendLayout();
                // 
                // Factory
                // 
                this.ClientSize = new System.Drawing.Size(176, 118);
                this.Name = "Factory";
                this.Load += new System.EventHandler(this.Factory_Load);
                this.ResumeLayout(false);

            }

            private void Factory_Load(object sender, EventArgs e)
            {

            }
        }
    }
