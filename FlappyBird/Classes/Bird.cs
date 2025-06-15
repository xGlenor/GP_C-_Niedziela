using System.Numerics;
using Raylib_cs;

public class Bird
{
    private Vector2 position;
    private Vector2 velocity;

    private float gravity;

    private const int SIZE = 20;
    private const float flapStrength = -8.0f;
    private const float maxVelocity = 10.0f;

    public Vector2 Position => position;

    public Bird(Vector2 startPosition)
    {
        this.position = startPosition;
        this.gravity = Constants.GRAVITY;
        this.velocity = new Vector2(0, 0);
    }

    public void Update()
    {
        velocity.Y += gravity;
        position += velocity;

        if (velocity.Y > maxVelocity)
        {
            velocity.Y = maxVelocity;
        }

        if (position.Y < 0)
        {
            position.Y = 0;
            velocity.Y = 0;
        }
    }

    //Todo
    // Stworzyć metode Draw, która rysuje ptaka
    public void Draw()
    {
        Raylib.DrawCircleV(position, SIZE, Color.Yellow);
    }
    // Stworzyć metodę, która będzie podbijała ptaka
    public void Flap()
    {
        velocity.Y = flapStrength;
    }
    // Stworzyć metodą, która będzie sprawdzała kolizję z podłożem
    public bool CheckCollisionWithGround()
    {
        return position.Y + SIZE > Constants.WINDOW_HEIGHT;
    }

}