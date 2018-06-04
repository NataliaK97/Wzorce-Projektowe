using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Interface kolczyki01 = new Silver();
            Interface kolczyki02 = new Gold();
            Interface kolczyki03 = new Wood();

            Makeing makeing = new Makeing();

            makeing.add(kolczyki01);
            makeing.stworz("Czerwony");

            makeing.add(kolczyki02);
            makeing.stworz("Zielony");
            
            makeing.add(kolczyki03);
            makeing.stworz("Niebieski");

            Console.ReadKey();
        }
    }
}
