using Raylib_cs;

namespace GraWZycie
{
    public class Siatka
    {
        private int[,] _tablicaKomorek;

        private const int ZYWA = 1;
        private const int MARTWA = 0;

        public Siatka(int iloscRzedow, int iloscKolumn, int ziarno)
        {
            _tablicaKomorek = new int[iloscRzedow, iloscKolumn];

            Random rand = new Random(ziarno);

            for (int i = 0; i < iloscRzedow; i++)
            {
                for (int j = 0; j < iloscKolumn; j++)
                {
                    int liczba = rand.Next(2);

                    _tablicaKomorek[i, j] = liczba == 1 ? ZYWA : MARTWA;
                }
            }

        }

        public Siatka(int[,] tablicaPrzykladowa, int iloscRzedow, int iloscKolumn)
        {
            _tablicaKomorek = new int[iloscRzedow, iloscKolumn];

            for (int x = 0; x < tablicaPrzykladowa.GetLength(0); x++)
            {
                for (int y = 0; y < tablicaPrzykladowa.GetLength(1); y++)
                {
                    _tablicaKomorek[x, y] = tablicaPrzykladowa[x, y];
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
            string wydrukuj = new string('-', _tablicaKomorek.GetLength(1) * 2) + "\n";

            for (int i = 0; i < _tablicaKomorek.GetLength(0); i++)
            {
                for (int j = 0; j < _tablicaKomorek.GetLength(1); j++)
                {
                    if (_tablicaKomorek[i, j] == ZYWA)
                    {
                        wydrukuj += "O";
                    }
                    else
                    {
                        wydrukuj += " ";
                    }
                    wydrukuj += " ";
                }
                wydrukuj += "|\n";
            }
            wydrukuj += new string('-', _tablicaKomorek.GetLength(1) * 2);

            Console.WriteLine(wydrukuj);
        }

        public void Rysuj(int rozmiarKomorki)
        {
            for (int x = 0; x < _tablicaKomorek.GetLength(0); x++)
            {
                for (int y = 0; y < _tablicaKomorek.GetLength(1); y++)
                {
                    Color color = _tablicaKomorek[x, y] == ZYWA ? Color.White : Color.Black;

                    Rectangle rect = new Rectangle(
                        y * rozmiarKomorki,
                        x * rozmiarKomorki,
                        rozmiarKomorki - 1,
                        rozmiarKomorki - 1
                    );

                    Raylib.DrawRectangleRec(rect, color);
                }
            }
        }

    }
}