﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class DefenderClass : TeamMember
    {
        public DefenderClass(string name)
        {
            this.Name = name;
        }
        public override void playersPosition(Position position)
        {
            if (position == Position.defender)
                Console.WriteLine("{0} play as: {1}", Name, position);
            else if (next != null)
                next.playersPosition(position);
        }
    }
}