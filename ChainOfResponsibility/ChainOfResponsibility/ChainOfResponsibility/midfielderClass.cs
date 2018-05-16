using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class MidfielderClass : TeamMember
    {
        public MidfielderClass(string name)
        {
            this.Name = name;
        }
        public override void playersPosition(Position position)
        {
            if (position == Position.midfielder)
                Console.WriteLine("{0} play as: {1}", Name, position);
            else if (next != null)
                next.playersPosition(position);
        }
    }
}