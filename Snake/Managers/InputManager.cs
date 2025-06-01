using System.Numerics;
using Raylib_cs;

public static class InputManager
{
    public static void HandleInputSnake(Snake snake)
    {
        if (Raylib.IsKeyPressed(KeyboardKey.Up))
            snake.ChangeDirection(new Vector2(0, -1));

        if (Raylib.IsKeyPressed(KeyboardKey.Down))
            snake.ChangeDirection(new Vector2(0, 1));

        if (Raylib.IsKeyPressed(KeyboardKey.Left))
            snake.ChangeDirection(new Vector2(-1, 0));
            
        if (Raylib.IsKeyPressed(KeyboardKey.Right))
            snake.ChangeDirection(new Vector2(1, 0));

        if (Raylib.IsKeyPressed(KeyboardKey.Space))
            snake.RandomColorSnake();
    }
}