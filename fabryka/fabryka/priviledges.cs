using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabryka
{
    class priviledges : Interface1
    {
        List<String> list;
        public priviledges()
        {
            list = new List<string>();
        }

        string Interface1.addItem(String privilege)
        {
            list.Add(privilege);
            return "Dodano nowy przywilej: " + privilege;
        }

        string Interface1.deleteItem(int number)
        {
            list.RemoveAt(number);
            return "Usunieto przywilej z numerem: " + number;
        }

        string Interface1.listItems()
        {
            foreach (object user in list)
                Console.WriteLine("Przywilej: " + user);
            return "";
        }
        string Interface1.sortItems()
        {
            return "posortowano";
        }
    }
}
