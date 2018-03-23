using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabryka
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Interface1 ob = null;

            try
            {
                ob = factory.getObject("users");
                ob.addItem("Osoba1");
                ob.addItem("Osoba2");
                Console.WriteLine(ob.listItems());
            }
            catch (Exception e)
            {
                Console.WriteLine("Operacja nie powiodła się");
            }

            try
            {
                ob = factory.getObject("products");

                ob.addItem("produkt1");
                ob.addItem("produkt2");
                Console.WriteLine(ob.listItems());
            }
            catch (Exception e)
            {
                Console.WriteLine("Operacja nie powiodła się");
            }

            Console.Read();
        }
    }
}