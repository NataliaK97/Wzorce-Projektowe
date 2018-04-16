using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento
{
    public class CareTaker
    {
        private Memento memento;
        public Memento Memento
        {
            get
            {
                return memento;
            }
            set
            {
                memento = value;
            }
        }
    }
}
