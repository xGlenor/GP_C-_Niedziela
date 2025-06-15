using System.Numerics;

public static class Constants
{
    public const int WINDOW_WIDTH = 800;
    public const int WINDOW_HEIGHT = 600;

    public static readonly float GRAVITY = 0.5f;
    public static readonly int COUNTDOWN = 3;

    public static Vector2 CenterPosition => new Vector2(WINDOW_WIDTH / 2, WINDOW_HEIGHT/2); 

}