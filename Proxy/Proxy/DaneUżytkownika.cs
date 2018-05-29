using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class DaneUżytkownika :Interface
    {
        Interface Ocena;
        private string haslo;
        public bool hasloOk;

        public void getHaslo (string _haslo)
        {
            haslo = _haslo;
            SprawdzHaslo();
        }
        private void SprawdzHaslo()
        {
            if (haslo=="hasloOkon")
            {
                otworzDostep();
                hasloOk = true;
            }
            else
            {
                hasloOk = false;
            }
        }
        private void otworzDostep()
        {
            OcenaFactory ocenaFactory = new OcenaZDziennka();
            Ocena = ocenaFactory.Dziennik();
        }
        public double WyswietlOcene()
        {
            return Ocena.WyswietlOcene();
        }
        public void ZmienOcene(double nowaOcena)
        {
            Ocena.ZmienOcene(nowaOcena);
        }
    }
}
