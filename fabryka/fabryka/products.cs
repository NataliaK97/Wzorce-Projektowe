using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabryka
{
    public class products : Interface1
    {
        List<String> list;
        public products()
        {
            list = new List<string>();
        }

        string Interface1.addItem(String user)
        {
            list.Add(user);
            return "Dodano nowy produkt: " + user;
        }

        string Interface1.deleteItem(int number)
        {
            list.RemoveAt(number);
            return "Usunieto produkt z numerem: " + number;
        }

        string Interface1.listItems()
        {
            foreach (object user in list)
                Console.WriteLine("Nazwa produktu: " + user);
            return "";
        }
    }
}