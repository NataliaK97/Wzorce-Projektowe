using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Silver : Interface
    {
        public void stworz(string kolor)
        {
            Console.WriteLine("Kolczyki srebrne, dodatki w kolorze: "+kolor);
        }
    }
}
