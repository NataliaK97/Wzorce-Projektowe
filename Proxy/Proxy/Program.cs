﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string pytanie;
            double nowaOcena;

            Console.WriteLine("Użytkowniku podaj hasło: ");
            string haslo = (Console.ReadLine());
            DaneUżytkownika daneUzytkownika = new DaneUżytkownika();
            daneUzytkownika.getHaslo(haslo);
            Ocena ocena = new Ocena();

            if (daneUzytkownika.hasloOk)
            {
                Console.WriteLine("Podałeś poprawne hasło");
                Console.WriteLine("Aktualna ocena to " + ocena.WyswietlOcene());
                Console.WriteLine("Czy chcesz zmianić ocene? (T/N)");
                pytanie = Console.ReadLine();

                if(pytanie=="T"|| pytanie == "t")
                {
                    Console.WriteLine("Podaj nową ocenę");
                    nowaOcena = double.Parse(Console.ReadLine());
                    if (nowaOcena>6 || nowaOcena<=0)
                    {
                        Console.WriteLine("Zły zakres!");
                    }
                    else
                    {
                        daneUzytkownika.ZmienOcene(nowaOcena);
                        Console.WriteLine("Aktualna ocena to: " + daneUzytkownika.WyswietlOcene());
                    }
                }
                else
                {
                    Console.WriteLine("Nie wprowadziłeś zmian.");
                    Console.WriteLine("Aktualna ocena to: " + daneUzytkownika.WyswietlOcene());
                }
            }
            else
            {
                Console.WriteLine("Błędne hasło!");
            }
            Console.ReadKey();
        }
    }
}
