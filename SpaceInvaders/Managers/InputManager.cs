using Raylib_cs;

public static class InputManager
{
    public static void HandleInput(Player player, List<Bullet> bullets)
    {
        if (Raylib.IsKeyDown(KeyboardKey.Left))
        {
            player.MoveLeft();
        }
        else if (Raylib.IsKeyDown(KeyboardKey.Right))
        {
            player.MoveRight();
        }
        if (Raylib.IsKeyPressed(KeyboardKey.Space))

        {
            bullets.Add(player.Shoot());
        }
    }
}