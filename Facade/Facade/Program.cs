using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Person user = new Person();
            Console.WriteLine("Wypisanie z użyciem klasy 'Person'");
            user.SetFirstName("Anna");
            user.SetLastName("Nowak");
            Console.WriteLine(user.GetFirstName());
            Console.WriteLine(user.GetLastName());

            PersonFacade userFacade = new PersonFacade(user);
            Console.WriteLine("\nWypisanie z użyciem klasy 'PersonFacade'");
            Console.WriteLine(userFacade.GetName());
            Console.ReadLine();
        }
    }
}
