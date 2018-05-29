using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Ocena : Interface
    {
        private double ocena = 5.0;
        public double WyswietlOcene()
        {
            return ocena;
        }
        public void ZmienOcene(double nowaOcena)
        {
            ocena = nowaOcena;
        }
    }
}
