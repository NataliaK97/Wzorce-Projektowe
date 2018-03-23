using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabryka
{
    public class products : Interface1
    {
        public String listItems()
        {
            return "Lista produktów";
        }
        public String addItem()
        {
            return "Dodaje produkt";
        }
        public String deleteItem()
        {
            return "Usuwa produkt";
        }
    }
}
