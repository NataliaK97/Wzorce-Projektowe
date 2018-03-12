using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dekorator
{

    abstract class Pizza
    {
        protected string pizza = " ";

        virtual public String about()
        {
            return pizza;
        }

        public abstract double cena();
    }

    abstract class Dekorator : Pizza
    {
        public abstract override String about();
    }

    class Duza : Pizza
    {
        public Duza()
        {
            pizza = "Duża pizza z serem";
        }
        public override double cena()
        {
            return 35;
        }
    }
    class Mala : Pizza
    {
        public Mala()
        {
            pizza = "Mała pizza z serem";
        }
        public override double cena()
        {
            return 15;
        }
    }


    class Szynka : Dekorator
    {
        Pizza p;

        public Szynka(Pizza pizza)
        {
            p = pizza;
        }

        public override String about()
        {
            return p.about() + " + szynka";
        }

        public override double cena()
        {
            return p.cena() + 8;
        }
    }

    class Pieczarki : Dekorator
    {
        Pizza p;

        public Pieczarki(Pizza pizza)
        {
            p = pizza;
        }

        public override String about()
        {
            return p.about() + " + pieczarki";
        }

        public override double cena()
        {
            return p.cena() + 7;
        }
    }

    public class Application
    {
        public static void Main(String[] args)
        {
            Pizza p1 = new Duza();
            Pizza p2 = new Mala();

            Console.WriteLine("Zwykła");
            Console.WriteLine(p1.about() + " " + p1.cena());
            Console.WriteLine(p2.about() + " " + p2.cena());

            //+szynka

            p1 = new Szynka(p1);
            p2 = new Szynka(p2);
            Console.WriteLine("\nZ szynką");
            Console.WriteLine(p1.about() + " " + p1.cena());
            Console.WriteLine(p2.about() + " " + p2.cena());

            //+pieczarki

            p1 = new Pieczarki(p1);
            p2 = new Pieczarki(p2);
            Console.WriteLine("\nZ pieczarkami");
            Console.WriteLine(p1.about() + " " + p1.cena());
            Console.WriteLine(p2.about() + " " + p2.cena());

            //lub
            Console.WriteLine("\nWszyskie dodatki");
            Pizza p3 = new Pieczarki(new Szynka(new Duza()));
            Console.WriteLine(p3.about() + " " + p3.cena());
            Console.ReadLine();
        }
    }
}