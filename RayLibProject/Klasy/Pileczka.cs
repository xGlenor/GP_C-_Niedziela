using System.Numerics;
using Raylib_cs;

public class Pileczka
{
    public Vector2 Pozycja { get; private set; }
    public Vector2 Predkosc { get; private set; }

    private List<Vector2> slad;

    private const float Grawitacja = 0.5f;
    private const float WspolczynnikOdbicia = -0.95f;
    private const int DlugoscSladu = 20;


    public Pileczka(Vector2 pozycjaStartowa)
    {
        Pozycja = pozycjaStartowa;
        Random random = new Random();
        Predkosc = new Vector2(
            (float)(random.NextDouble() * 2 - 1) * 5,
            (float)(random.NextDouble() * 2 - 1) * 5
        );

        slad = new List<Vector2>();
    }

    public void Aktualizuj()
    {
        // Tworzenie kopii Predkosc do modyfikacji
        Vector2 nowaPredkosc = Predkosc;
        nowaPredkosc.Y += Grawitacja;

        Vector2 nowaPozycja = Pozycja;
        nowaPozycja += nowaPredkosc;

        //Odobicie od podłogi
        if (nowaPozycja.Y >= Raylib.GetScreenHeight())
        {
            nowaPozycja.Y = Raylib.GetScreenHeight();
            nowaPredkosc.Y *= WspolczynnikOdbicia;
        }

        // Aktualizacja właściwości Pozycja i Predkosc
        Pozycja = nowaPozycja;
        Predkosc = nowaPredkosc;

        slad.Add(Pozycja);

        if (slad.Count > DlugoscSladu)
            slad.RemoveAt(0);
    }

    public void Rysuj()
    {
        for (int i = 0; i < slad.Count - 1; i++)
        {
            float alpha = (float)i / slad.Count;
            Color colorAlpha = Raylib.ColorAlpha(Color.Red, alpha);
            Raylib.DrawLineV(slad[i], slad[i + 1], colorAlpha);
        }

        Raylib.DrawCircleV(Pozycja, 10, Color.Green);
    }
}