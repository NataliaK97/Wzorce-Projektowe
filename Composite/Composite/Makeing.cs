using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Makeing : Interface
    {
        private List<Interface> lista = new List<Interface>();

        public void stworz(string kolor)
        {
            foreach (Interface inter in lista)
            {
                inter.stworz(kolor);
            }
        }

        public void add(Interface i)
        {
            lista.Add(i);
        }
        public void remove(Interface i)
        {
            lista.Remove(i);
        }
    }
}
