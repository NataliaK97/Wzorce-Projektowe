using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Gold : Interface
    {
        public void stworz(string kolor)
        {
            Console.WriteLine("Kolczyki złote, dodatki w kolorze: "+kolor);
        }
    }
}
