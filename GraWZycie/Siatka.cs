namespace GraWZycie
{
    public class Siatka
    {
        private int[,] _tablicaKomorek;

        private const int ZYWA = 1;
        private const int MARTWA = 0;

        public Siatka(int iloscRzedow, int iloscKolumn)
        {
            _tablicaKomorek = new int[iloscRzedow, iloscKolumn];

            Random rand = new Random();

            for (int i = 0; i < iloscRzedow; i++)
            {
                for (int j = 0; j < iloscKolumn; j++)
                {
                    int liczba = rand.Next(2);

                    _tablicaKomorek[i, j] = liczba == 1 ? ZYWA : MARTWA;
                }
            }

        }

        public void ZrobKrok()
        {
            int[,] noweKomorki = new int[_tablicaKomorek.GetLength(0), _tablicaKomorek.GetLength(1)];

            for (int i = 0; i < _tablicaKomorek.GetLength(0); i++)
            {
                for (int j = 0; j < _tablicaKomorek.GetLength(1); j++)
                {
                    noweKomorki[i, j] = ZastosujZasady(i, j);
                }
            }

            _tablicaKomorek = noweKomorki;

        }

        private int PoliczZywychSasiadow(int nrRzedu, int nrKolumny)
        {
            int licznik = 0;

            for (int i = nrRzedu - 1; i <= nrRzedu + 1; i++)
            {
                for (int j = nrKolumny - 1; j <= nrKolumny + 1; j++)
                {

                    if (i >= 0 && i < _tablicaKomorek.GetLength(0) &&
                        j >= 0 && j < _tablicaKomorek.GetLength(1) &&
                        !(i == nrRzedu && j == nrKolumny)
                    )
                    {
                        if (_tablicaKomorek[i, j] == ZYWA)
                            licznik++;
                    }

                }
            }

            return licznik;
        }

        private int ZastosujZasady(int nrRzedu, int nrKolumny)
        {
            int liczbaSasiadow = PoliczZywychSasiadow(nrRzedu, nrKolumny);

            if (_tablicaKomorek[nrRzedu, nrKolumny] == ZYWA)
            {
                if (liczbaSasiadow == 2 || liczbaSasiadow == 3)
                    return ZYWA;
            }
            else
            {
                if (liczbaSasiadow == 3)
                    return ZYWA;
            }

            return MARTWA;
        }

        public void Wydrukuj()
        {
            for (int i = 0; i < _tablicaKomorek.GetLength(0); i++)
            {
                for (int j = 0; j < _tablicaKomorek.GetLength(1); j++)
                {
                    if (_tablicaKomorek[i, j] == ZYWA)
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

    }
}