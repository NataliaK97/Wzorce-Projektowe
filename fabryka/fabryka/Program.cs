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

            string nameC;
            do
            {
                Console.WriteLine("Podaj nazwę klasy (users lub products) ");
                nameC = Console.ReadLine();
            }
            while (nameC != "products" && nameC != "users");

            Console.WriteLine("Wybrałeś klasę: {0}", nameC);

            if(nameC=="users")
            {
                try
                {
                    ob = factory.getObject("users");
                    ob.addItem("Osoba1");
                    ob.addItem("Osoba2");
                    ob.addItem("Osoba3");
                    Console.WriteLine(ob.listItems());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Operacja nie powiodła się");
                }
            }
            if (nameC=="products")
            {
                try
                {
                    ob = factory.getObject("products");
                    ob.addItem("produkt1");
                    ob.addItem("produkt2");
                    ob.addItem("produkt3");
                    Console.WriteLine(ob.listItems());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Operacja nie powiodła się");
                }
            }
            Console.Read();
        }
    }
}