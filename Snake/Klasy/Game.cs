using System.Numerics;
using Raylib_cs;

public class Game
{
    private bool IsGameEnd;
    private int gridSize;

    private int points = 0;
    private int velocity = 10;

    private Snake snake;
    private Food food;

    private void Init()
    {
        gridSize = 40;
        IsGameEnd = false;

        Raylib.InitWindow(Constants.WINDOW_WIDTH, Constants.WINDOW_HEIGHT, "Snake game");
        Raylib.SetTargetFPS(velocity);

        snake = new Snake(gridSize, Constants.WINDOW_WIDTH, Constants.WINDOW_HEIGHT);
        food = new Food(Constants.WINDOW_HEIGHT, Constants.WINDOW_WIDTH, gridSize);
        
    }

    public void Start()
    {
        Init();

        while (!Raylib.WindowShouldClose())
        {
            // Pierwsze aktualizujemy
            Update();
            // Później Rysujemy
            Draw();
        }

        Raylib.CloseWindow();
    }

    public void Draw()
    {
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.Black);

        snake.Draw();
        food.Draw();

        Raylib.DrawText(points.ToString().PadLeft(2, '0'), 20, 20, 40, Color.White);

        if (IsGameEnd)
        {
            Raylib.DrawText("End of Game", Constants.WINDOW_WIDTH / 2 - 200, Constants.WINDOW_HEIGHT / 2 - 70, 70, Color.Red);
            Raylib.DrawText("Press enter to start again", Constants.WINDOW_WIDTH / 2 - 190, Constants.WINDOW_HEIGHT / 2 + 20, 30, Color.White);
        }

        Raylib.EndDrawing();
    }

    public void Update()
    {
        //Obsługa restartu Gry
        if (IsGameEnd)
        {
            if (Raylib.IsKeyPressed(KeyboardKey.Enter))
            {
                RestartGame();
            }
            return;
        }

        // Obsługa klawiszy
        InputManager.HandleInputSnake(snake);

        if (snake.CheckCollision(food.Position))
        {
            snake.Grow();
            food.GenerateNewPosition();
            points++;
            velocity = Math.Min(60, velocity + 1);
            Raylib.SetTargetFPS(velocity);
        }

        // Poruszanie Węża
        snake.Move();

        // Sprawdzenie Kolizji
        if (snake.CheckSelfCollision())
            IsGameEnd = true;
    }

    public void RestartGame()
    {
        points = 0;
        velocity = 10;
        snake = new Snake(gridSize, Constants.WINDOW_WIDTH, Constants.WINDOW_HEIGHT);
        food = new Food(Constants.WINDOW_HEIGHT, Constants.WINDOW_WIDTH, gridSize);
        IsGameEnd = false;
        Raylib.SetTargetFPS(velocity);
    }

}