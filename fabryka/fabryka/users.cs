using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabryka
{
    public class users : Interface1
    {
        public String listItems()
        {
            return "Lista uzytkowników";
        }
        public String addItem()
        {
            return "Dodaje uzytkownika";
        }
        public String deleteItem()
        {
            return "Usuwa uzytkownika";
        }
    }
}
