using System.Numerics;
using Raylib_cs;

public class AnimationGame
{
    int x, y, speedX, speedY, squareSize;
    Texture2D dvdLogo;

    public void Init()
    {
        Raylib.InitWindow(800, 600, "Odbijący sie kwadrat");
        Raylib.SetTargetFPS(60);

        dvdLogo = Raylib.LoadTexture(@"Assets\dvdLogo.png");
        speedX = 5;
        speedY = 3;
        squareSize = 40;

        x = Raylib.GetScreenWidth() / 2 - squareSize / 2;
        y = Raylib.GetScreenHeight() / 2 - squareSize / 2;
    }

    public void Play()
    {

        while (!Raylib.WindowShouldClose())
        {
            Update();
            Draw();
        }
        Raylib.UnloadTexture(dvdLogo);
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

        Raylib.ClearBackground(Color.White);

        //Raylib.DrawRectangle(x, y, squareSize, squareSize, Color.Green);
        Raylib.DrawTextureEx(dvdLogo, new Vector2(x, y), 0f, 0.06f, Color.White);

        Raylib.EndDrawing();

    }

}