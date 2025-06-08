using Raylib_cs;

public class Game
{
    private int score;
    private float countdownTimer;
    private int countdown;

    private GameStatus gameStatus;


    //Inicializuje okno gry, ustawienia początkowy, przygotowanie obiektów
    public void Initialize()
    {
        Raylib.InitWindow(Constants.WINDOW_WIDTH, Constants.WINDOW_HEIGHT, "Flappy Bird Game");
        Raylib.SetTargetFPS(60);

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
            // Draw Pipes

            // Draw GameOver status
            if (gameStatus == GameStatus.GameOver)
            {
                Raylib.DrawText(
                    "Game Over",
                    Constants.WINDOW_WIDTH / 2 - 160,
                    Constants.WINDOW_HEIGHT / 2 - 50,
                    70, Color.Red
                );

                Raylib.DrawText(
                    "Press Enter to Restart",
                    Constants.WINDOW_WIDTH / 2 - 170,
                    Constants.WINDOW_HEIGHT / 2 + 30,
                    30, Color.White
                );
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