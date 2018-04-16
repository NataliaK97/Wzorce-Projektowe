using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento
{
    public class Person
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public void SetMemento(Memento memento)
        {
            this.name = memento.Name;
        }
        public Memento CreateMemento()
        {
            return new Memento(name);
        }
    }
}
