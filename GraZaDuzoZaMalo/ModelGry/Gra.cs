using System;
using System.Collections.Generic;

namespace ModelGry
{
    public partial class Gra
    {
        // typy
        public enum Odp { ZaMało=-1, Trafiono=0, ZaDużo=+1};
        public enum StanGry { Trwa, Poddana, Odgadnieta };
        // pola
        private readonly int wylosowana;
        int ZakresOd, ZakresDo;
        public StanGry Stan { get; private set; }

        public int LicznikRuchow {get; private set;} = 0;

        // TO DO: historia rozgrywki
        public Gra(int min, int max)
        {
            ZakresOd = min;
            ZakresDo = max;
            wylosowana = Losuj(ZakresOd, ZakresDo);
            Stan = StanGry.Trwa;
            Historia = new List<Ruch>();
        }
        private int Losuj(int min = 1, int max = 100)
        {
            Random generator = new Random();
            int los = generator.Next(min, max + 1);
            return los;
        }

        public Odp Ocena(int propozycja)
        {
            LicznikRuchow++;
            Odp odp;
            if (propozycja < wylosowana)
                odp = Odp.ZaMało;
            else if (propozycja > wylosowana)
                odp = Odp.ZaDużo;
            else // ==
            {
                Stan = StanGry.Odgadnieta;
                odp = Odp.Trafiono;
            }
            Historia.Add(new Ruch(propozycja, odp));
            return odp;
        }

        public void Poddaj()
        {
            Stan = StanGry.Poddana;
        }
        public int? CoBylWylosowane()
        {
            if (Stan != StanGry.Trwa)
                return wylosowana;
            else
                return null;
        }
    }
}
