using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_proceduralnie
{
    class Program
    {
        /// <summary>
        /// Wczytuje dane (liczba całkowita) z konsoli. Jesli "x" zgłaszam wyjątek
        /// </summary>
        /// <param name="prompt">Tekst zachęty wyświetlany użytkownikowi</param>
        /// <returns>Liczba odczytana ze standardowego wyjścia</returns>
        /// <exception cref="InvalidOperationException">Gdy użytkownik poda znak "x"</exception>
        private static int WczytajDane(string prompt = "Podaj liczbę lub x jeśli:")
        {

            int propozycja = 0;
            do
            {
                Console.WriteLine(prompt);
                string tekst = Console.ReadLine();
                if (tekst.ToLower() == "x")
                    throw new InvalidOperationException();
                try
                {
                    propozycja = Convert.ToInt32(tekst); //int.Pase(text)
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nie podano liczby! Spróbuj jeszcze raz");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Liczba nie mieści się w rejestrze! Spróbuj jeszcze raz");
                }
            }
            while (true);
            return propozycja;
        }
        private static int Losuj(int min = 1, int max = 100)
        {
            Random generator = new Random();
            int wylosowana = generator.Next(min, max+1);
            return wylosowana;
        }
        private static int wylosowana = 0;

        private static string Ocena(int propozycja)
        {
            if (propozycja < wylosowana)
                return "Za mało";
            else if (propozycja > wylosowana)
                return "Za dużo";
            else
            {
                return"Trafiono";
            }
        }
        public static void Main(string[] args)
        {
            //1.komputer losuje liczbe
            wylosowana = Losuj(1, 100); //może być zgłoszony wyjątek, gdy min > max
            Console.WriteLine("Wylosowałem liczbe od 1 do 100, \n Odgadnij ją");
#if(DEBUG)
            Console.WriteLine(wylosowana);
#endif

            //wykonuj
            int propozycja = 0;
            do
            {
                try
                { 
                    propozycja = WczytajDane("Podaj swoją propozycje (x - gdy koniec)");
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("Szkoda że kończymy Do widzenia");
                    return;
                }
                Console.WriteLine($"Przyjąłem wartość {propozycja}");
                string ocena = Ocena(propozycja);
                Console.WriteLine(Ocena(propozycja));
                if (ocena == "trafiono")
                    break;
            }
            while (true);
            //do momentu trafienia
            Console.WriteLine("Koniec gry");
        }
    }
}
