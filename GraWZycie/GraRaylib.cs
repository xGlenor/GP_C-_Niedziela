using GraWZycie;
using Raylib_cs;

public class GraRaylib
{
    private const int SZEROKOSC_OKNA = 800;
    private const int WYSOKOSC_OKNA = 600;
    private const int ROZMIAR_KOMORKI = 20;
    private const float CZAS_MIEDZY_KROKAMI = 0.3f;

    private Siatka siatka;
    private float czasOdOstatniegoKroku;
    private bool symulacjaWlaczona;

    private int iloscKolumn;
    private int iloscRzedow;

    public void Inicjalizuj()
    {
        Raylib.InitWindow(SZEROKOSC_OKNA, WYSOKOSC_OKNA, "Gray w życie - Conway");
        Raylib.SetTargetFPS(60);

        UstawSiatke();

        czasOdOstatniegoKroku = 0.0f;
        symulacjaWlaczona = false;

    }


    public void Aktualizuj()
    {
        float deltaTime = Raylib.GetFrameTime();
        czasOdOstatniegoKroku += deltaTime;

        if (Raylib.IsKeyPressed(KeyboardKey.Space))
            symulacjaWlaczona = !symulacjaWlaczona;

        if (Raylib.IsKeyPressed(KeyboardKey.Enter))
            siatka.ZrobKrok();

        if (Raylib.IsKeyPressed(KeyboardKey.R))
            UstawSiatke();

        if (symulacjaWlaczona && czasOdOstatniegoKroku >= CZAS_MIEDZY_KROKAMI)
        {
            siatka.ZrobKrok();
            czasOdOstatniegoKroku = 0.0f;
        }
        

    }

    public void UstawSiatke()
    {
        iloscRzedow = WYSOKOSC_OKNA / ROZMIAR_KOMORKI;
        iloscKolumn = SZEROKOSC_OKNA / ROZMIAR_KOMORKI;

        Random rand = new Random();

        siatka = new Siatka(iloscRzedow, iloscKolumn, rand.Next());
    }

    public void Rysuj()
    {
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.DarkGray);

        // Linie dla kolumn
        for (int x = 0; x <= iloscKolumn; x++)
        {
            Raylib.DrawLine(x * ROZMIAR_KOMORKI, 0, x * ROZMIAR_KOMORKI, WYSOKOSC_OKNA, Color.Gray);
        }

        // Linie dla rzedów
        for (int y = 0; y <= iloscRzedow; y++)
        {
            Raylib.DrawLine(0, y * ROZMIAR_KOMORKI, SZEROKOSC_OKNA, y * ROZMIAR_KOMORKI, Color.Gray);
        }

        siatka.Rysuj(ROZMIAR_KOMORKI);

        string instrukcje = symulacjaWlaczona ?
            "SPACJA - Pauza | ENTER - Krok | R - Reset" :
            "SPACJA - Start | ENTER - Krok | R - Reset";

        Raylib.DrawText(instrukcje, 10, 10, 20, Color.Red);


        Raylib.EndDrawing();
    }
    
    public void Uruchom()
    {
        while (!Raylib.WindowShouldClose())
        {
            Aktualizuj();
            Rysuj();
        }
        
        Raylib.CloseWindow();
    }
}