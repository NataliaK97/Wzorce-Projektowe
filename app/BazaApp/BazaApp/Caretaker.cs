using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazaApp
{
    public class Caretaker
    {
        private List<Memento> listaMemento;
        public static int stos = 0;
        Form1 form1;

        public Caretaker(Form1 thisForm1)
        {
            this.form1 = thisForm1;
        }

        public List<Memento> GetMemento()
        {
            if (listaMemento==null)
            {
                listaMemento = new List<Memento>();
            }
            return listaMemento;
        }
        public void AddMemento(Memento memento)
        {
            GetMemento().Add(memento);
            stos = stos + 1;
        }
        public Memento GetMemento (int numer)
        {
            return listaMemento[numer];
        }

    }
}
