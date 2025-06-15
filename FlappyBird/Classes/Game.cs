using System.Numerics;
using Raylib_cs;

public class Game
{
    private int score;
    private float countdownTimer;
    private int countdown;

    private GameStatus gameStatus;
    private Bird bird;
    private PipeManager pipeManager;

    //Inicializuje okno gry, ustawienia początkowy, przygotowanie obiektów
    public void Initialize()
    {
        Raylib.InitWindow(Constants.WINDOW_WIDTH, Constants.WINDOW_HEIGHT, "Flappy Bird Game");
        Raylib.SetTargetFPS(60);

        bird = new Bird(new Vector2(Constants.WINDOW_WIDTH / 4, Constants.WINDOW_HEIGHT / 2));
        pipeManager = new PipeManager();
        score = 0;
        gameStatus = GameStatus.Ready;
        countdownTimer = 0;
        countdown = Constants.COUNTDOWN;
    }

    public void Update()
    {
        if (gameStatus == GameStatus.Ready)
        {
            countdownTimer += Raylib.GetFrameTime();

            if (countdownTimer >= 1)
            {
                countdown--;
                countdownTimer = 0;
            }

            if (countdown <= 0)
                gameStatus = GameStatus.Playing;

        }
        else if (gameStatus == GameStatus.Playing)
        {
            bird.Update();

            if (Raylib.IsKeyPressed(KeyboardKey.Space))
                bird.Flap();

            score = pipeManager.AddPoint(score);

            pipeManager.Update();

            if (bird.CheckCollisionWithGround() || pipeManager.CheckCollision(bird.Position))
                gameStatus = GameStatus.GameOver;

        }
    }

    public void Draw()
    {
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.SkyBlue);

        if (gameStatus == GameStatus.Ready)
        {
            Raylib.DrawText(
                countdown.ToString(),
                Constants.WINDOW_WIDTH / 2 - 20,
                Constants.WINDOW_HEIGHT / 2 - 20,
                70, Color.Red);
        }
        else
        {
            // Draw Bird
            bird.Draw();
            // Draw Pipes
            pipeManager.Draw();
            // Draw GameOver status
            if (gameStatus == GameStatus.GameOver)
            {
                TextUtil.CenterDrawText("Game Over", 70, Color.Red, -50);
                TextUtil.CenterDrawText("Press Enter to Restart", 30, Color.White, +30);
            }
            // Draw Scores
            Raylib.DrawText($"Score: {score}", 10, 10, 30, Color.Black);
            
        }
        Raylib.EndDrawing();
    }


    // Uruchamia główną pętle gry, wywołuje dwie metody Update i Draw
    public void Run()
    {

        Initialize();

        while (!Raylib.WindowShouldClose())
        {
            Update();
            Draw();
        }
        
        Raylib.CloseWindow();
    }
}