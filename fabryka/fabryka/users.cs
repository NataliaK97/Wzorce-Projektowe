using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabryka
{
    public class users : Interface1
    {
        List<String> list;
        public users()
        {
            list = new List<string>();
        }

        string Interface1.addItem(String user)
        {
            list.Add(user);
            return "Dodano nowego uzytkwonika: " + user;
        }

        string Interface1.deleteItem(int number)
        {
            list.RemoveAt(number);
            return "Usunieto uzytkwonika z numerem: " + number;
        }

        string Interface1.listItems()
        {
            foreach (object user in list)
                Console.WriteLine("Nazwa uzytkownika: " + user);
            return "";
        }
    }
}