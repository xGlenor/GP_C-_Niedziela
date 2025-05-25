using Raylib_cs;

public class Game
{
    private bool IsGameEnd;
    private int widthScreen;
    private int heightScreen;
    private int gridSize;

    private int points = 0;
    private int velocity = 10;

    private void Init()
    {
        widthScreen = 800;
        heightScreen = 640;
        gridSize = 40;
        IsGameEnd = false;

        Raylib.InitWindow(widthScreen, heightScreen, "Snake game");
        Raylib.SetTargetFPS(velocity);
    }

    public void Start()
    {
        Init();

        while (!Raylib.WindowShouldClose())
        {
            // Pierwsze aktualizujemy

            // Później Rysujemy
            Draw();
        }

        Raylib.CloseWindow();
    }

    public void Draw()
    {
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.Black);

        Raylib.DrawText(points.ToString().PadLeft(2, '0'), 20, 20, 40, Color.White);

        if (IsGameEnd)
        {
            Raylib.DrawText("End of Game", widthScreen / 2 - 200, heightScreen / 2 - 70, 70, Color.Red);
            Raylib.DrawText("Press enter to start again", widthScreen / 2 - 190, heightScreen / 2 + 20, 30, Color.White);
        }

        Raylib.EndDrawing();
    }

    public void Update()
    {
        // Obsługa klawiszy
        // Poruszanie Węża
        // Sprawdzenie Kolizji
    }
}