using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraMonolitycznie
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Witaj! ");
            Console.Write("Podaj swoję imie: ");
            string x = Console.ReadLine();
            Console.WriteLine($"Witaj {x}");
            */

            //1.komputer losuje liczbe
            Random generator = new Random();
            int wylosowana = generator.Next(1, 101);
            Console.WriteLine("Wylosowałem liczbe od 1 do 100, \n Odgadnij ją" );
#if(DEBUG)
            Console.WriteLine(wylosowana);
#endif

            //2.czlowiek proponuje roziwazanie

            Console.Write("Podaj swoją propozycję: ");
            string tekst = Console.ReadLine();
            int propozycja = Convert.ToInt32(tekst);
            Console.WriteLine($"Przyjąłem wartość {propozycja}" );



            //3.komputer ocenia propozycje,
            if (propozycja<wylosowana)
                Console.WriteLine("Za mało");
            else if(propozycja > wylosowana)
                Console.WriteLine("Za dużo");
            else
                Console.WriteLine("Trafiono");



            Console.WriteLine("Koniec gry");
            string a = Console.ReadLine();
        }
    }
}
