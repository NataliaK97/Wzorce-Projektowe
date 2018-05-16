using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    abstract class Player
    {
        public string Name { get; set; }
        protected Player nextPlayer;

        public void SetNextPlater(Player player)
        {
            nextPlayer = player;
        }

        public abstract void playersPosition(Position position); 
    }
}
