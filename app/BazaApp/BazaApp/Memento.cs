using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaApp
{
    public class Memento
    {
        private String text;

        public Memento (String thisText)
        {
            this.text = thisText;
        }
        public String getText()
        {
            return text;
        }
    }
}
