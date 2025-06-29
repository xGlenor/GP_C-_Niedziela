using Raylib_cs;

Raylib.InitWindow(Constants.WINDOW_WIDTH, Constants.WINDOW_HEIGHT, "Space Invaders");
Raylib.SetTargetFPS(60);

GameManager.Initialize();

while (!Raylib.WindowShouldClose())
{
    GameManager.Update();
    GameManager.Draw();

}

Raylib.CloseWindow();