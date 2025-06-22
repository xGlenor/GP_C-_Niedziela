using Raylib_cs;

public class Game
{
    int centerX;
    int centerY;
    int eyeRadius;
    int pupilRadius;

    public void Init()
    {
        Raylib.InitWindow(800, 600, "Rysowanie Oczu");
        Raylib.SetTargetFPS(60);
        centerX = Raylib.GetScreenWidth() / 2;
        centerY = Raylib.GetScreenHeight() / 2;
        eyeRadius = 50;
        pupilRadius = 20;
    }

    public void Play()
    {
        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Raylib_cs.Color.Gray);
            RayLibUtils.DrawEyes(centerX - 70, centerY, eyeRadius, pupilRadius);

            RayLibUtils.DrawEyes(centerX + 70, centerY, eyeRadius, pupilRadius);

            Raylib.EndDrawing();
        }
        Raylib.CloseWindow();
    }



}