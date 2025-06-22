using Raylib_cs;

public class AnimationGame
{
    int x, y, speedX, speedY;
    int squareSize;

    public void Init()
    {
        Raylib.InitWindow(800, 600, "Odbijący sie kwadrat");
        Raylib.SetTargetFPS(60);
        squareSize = 50;
        x = Raylib.GetScreenWidth() / 2 - squareSize / 2;
        y = Raylib.GetScreenHeight() / 2 - squareSize / 2;
        speedX = 5;
        speedY = 3;
    }

    public void Play()
    {

        while (!Raylib.WindowShouldClose())
        {
            Update();
            Draw();
        }

        Raylib.CloseWindow();
    }

    public void Update()
    {
        x += speedX;
        y += speedY;

        if (x <= 0 || x + squareSize >= Raylib.GetScreenWidth())
        {
            speedX *= -1;
        }

        if (y <= 0 || y + squareSize >= Raylib.GetScreenHeight())
        {
            speedY *= -1;
        }

    }

    public void Draw()
    {
        Raylib.BeginDrawing();

        Raylib.ClearBackground(Color.Black);

        Raylib.DrawRectangle(x, y, squareSize, squareSize, Color.Green);

        Raylib.EndDrawing();

    }

}