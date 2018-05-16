using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    abstract class TeamMember
    {
        public string Name { get; set; }
        protected TeamMember next;

        public void SetNext(TeamMember teamMember)
        {
            next = teamMember;
        }

        public abstract void playersPosition(Position position); 
    }
}
