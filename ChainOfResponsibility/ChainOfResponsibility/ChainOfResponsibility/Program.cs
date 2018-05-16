using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamMember goalkeeper = new GoalkeeperClass("Ter Stegen");
            TeamMember defender = new DefenderClass("Pique");
            TeamMember midfielder = new MidfielderClass("Rakitic");
            TeamMember forward = new ForwardClass("Messi");
            TeamMember coach = new CoachClass("Valverde");
            
            goalkeeper.SetNext(defender);
            defender.SetNext(midfielder);
            midfielder.SetNext(forward);
            forward.SetNext(coach);

            List<Position> squad = new List<Position>
            {
                Position.coach,
                Position.forward,
                Position.midfielder,
                Position.goalkeeper,
                Position.defender
            };

            Console.WriteLine("FC Barcelona Team\n");

            foreach (var position in squad)
                goalkeeper.playersPosition(position);

            Console.ReadLine();
        }
    }
}
