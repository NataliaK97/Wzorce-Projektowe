using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Wood : Interface
    {
        public void stworz(string kolor)
        {
            Console.WriteLine("Kolczyki drewniane w kolorze: " + kolor);
        }
    }
}
