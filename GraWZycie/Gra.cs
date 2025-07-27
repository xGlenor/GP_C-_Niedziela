using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraWZycie
{
    public class Gra
    {
        
        private Siatka _siatka;

        public Gra(int liczbaRzedow, int liczbaKolumn, int ziarno)
        {
            _siatka = new Siatka(liczbaRzedow, liczbaKolumn, ziarno);
        }

        public Gra(Siatka siatka)
        {
            _siatka = siatka;
        }

        public void Uruchom(int liczbaIteracji)
        {
            for (int i = 0; i < liczbaIteracji; i++)
            {
                Console.Clear();
                Console.WriteLine($"Iteracja {i}:");

                _siatka.ZrobKrok();

                _siatka.Wydrukuj();

                Console.ReadKey();

            }
        }

    }
}