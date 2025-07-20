using System.Numerics;
using Raylib_cs;

Raylib.InitWindow(800, 600, "Symulacja upuszczania piłeczki");
Raylib.SetTargetFPS(60);


List<Pileczka> pileczki = new List<Pileczka>();

// Główna pętla gry
while (!Raylib.WindowShouldClose())
{

    if (Raylib.IsMouseButtonPressed(MouseButton.Left))
    {
        Vector2 pozycja = Raylib.GetMousePosition();
        pileczki.Add(new Pileczka(pozycja));
    }

    foreach (var pileczka in pileczki)
    {
        pileczka.Aktualizuj();
    }


    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.White);

    pileczki.ForEach(p => p.Rysuj());

    Raylib.EndDrawing();

}

Raylib.CloseWindow();