using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memento
{
    public partial class Form1 : Form
    {
        Person osoba;
        CareTaker[] careTaker;
        int licz = 0;
        public Form1()
        {
            InitializeComponent();
            osoba = new Person();
            careTaker = new CareTaker[10];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DisplayPersonInformation()
        {
            textBox1.Text = osoba.Name;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (licz < 10)
            {
                careTaker[licz] = new CareTaker();
                careTaker[licz].Memento = osoba.CreateMemento();
                licz++;
                osoba.Name = textBox1.Text;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (licz > 1)
            {
                licz--;
                osoba.SetMemento(careTaker[licz].Memento);
                DisplayPersonInformation();
            }
        }
    }
}

