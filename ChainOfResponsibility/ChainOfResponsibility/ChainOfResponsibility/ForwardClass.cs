using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class ForwardClass : Player
    {
        public ForwardClass(string name)
        {
            this.Name = name;
        }
        public override void playersPosition(Position position)
        {
            if (position == Position.forward)
                Console.WriteLine("{0}: {1} play as: {2}", this.GetType().Name, Name, position);
            else if (nextPlayer != null)
                nextPlayer.playersPosition(position);
        }
    }
}