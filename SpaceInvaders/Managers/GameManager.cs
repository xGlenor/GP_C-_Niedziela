using Raylib_cs;

public static class GameManager
{
    private static Player player;
    private static List<Bullet> bullets;
    private static List<Enemy> enemies;
    private static GameState gameState = GameState.Playing;

    public static void Initialize()
    {
        player = new Player();
        bullets = new List<Bullet>();
        enemies = new List<Enemy>();

        for (int row = 0; row < Constants.ENEMY_ROWS; row++)
        {
            for (int col = 0; col < Constants.ENEMY_COLUMNS; col++)
            {
                var enemy = new Enemy(new Vector2D(
                    100 + col * 60,
                    100 + row * 40
                ));

                enemies.Add(enemy);
            }
        }
    }


    public static void Update()
    {
        if (gameState == GameState.Playing)
        {
            InputManager.HandleInput(player, bullets);
            player.Update();

            bool changeDirection = false;

            foreach (var enemy in enemies)
            {
                enemy.Update();

                if (enemy.Position.X >= Constants.WINDOW_WIDTH - enemy.Size.X / 2
                    || enemy.Position.X <= enemy.Size.X / 2
                )
                {
                    changeDirection = true;
                }

                if (enemy.Position.Y + enemy.Size.Y / 2 >= Constants.WINDOW_HEIGHT)
                {
                    gameState = GameState.Lost;
                }
            }

            if (changeDirection)
            {
                foreach (var enemy in enemies)
                {
                    enemy.Move(new Vector2D(0, Constants.ENEMY_DROP_DISTANCE));
                    enemy.SwitchDirection();
                }
            }

            foreach (var bullet in bullets)
            {
                bullet.Update();
            }
            //bullets.ForEach(b => b.Update());

            CollisionManager.HandleCollisions(player, bullets, enemies);

            if (enemies.Count <= 0)
            {
                gameState = GameState.Won;
            }

        }
    }

    public static void Draw()
    {
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.Black);
        player.Draw();
        foreach (var bullet in bullets)
        {
            bullet.Draw();
        }

        enemies.ForEach(enemy => enemy.Draw());

        Raylib.EndDrawing();
    }

    public static void SetGameState(GameState state)
    {
        gameState = state;
    }

}