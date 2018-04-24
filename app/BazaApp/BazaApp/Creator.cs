using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaApp
{
    class Creator
    {
        private String text;
        public Creator(String thisText) 
        {
            this.text = thisText;
        }
        public Creator()
        {
            this.text = "";
        }

        public void setText(String thisText) 
        {
            this.text = thisText;
        }

        public String getText()
        {
            return text;
        }

        public Memento createMemento()
        {
            return new Memento(this.text);
        }

        public void renewMemento(Memento memento)
        {
            this.text = memento.getText();
        }
    }
}