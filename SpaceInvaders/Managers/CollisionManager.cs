public class CollisionManager
{

    public static void HandleCollisions(Player player, List<Bullet> bullets, List<Enemy> enemies)
    {

        foreach (var bullet in bullets)
        {
            foreach (var enemy in enemies)
            {
                if (bullet.CollidesWith(enemy))
                {
                    bullet.IsActive = false;
                    enemy.IsActive = false;
                }
            }
        }

        bullets.RemoveAll(b => !b.IsActive);
        enemies.RemoveAll(e => !e.IsActive);

        if (enemies.Any(e => e.CollidesWith(player)))
        {
            player.IsActive = false;
            GameManager.SetGameState(GameState.Lost);
        }

        foreach (var enemy in enemies)
        {
            if (enemy.Position.Y + enemy.Size.Y / 2 >= Constants.WINDOW_HEIGHT)
            {
                GameManager.SetGameState(GameState.Lost);
                break;
            }
        }

    }

}