using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class CoachClass : TeamMember
    {
        public CoachClass(string name)
        {
            this.Name = name;
        }
        public override void playersPosition(Position position)
        {
            if (position == Position.coach)
                Console.WriteLine("{0} is a {1}", Name, position);
            else if (next != null)
                next.playersPosition(position);
        }
    }
}