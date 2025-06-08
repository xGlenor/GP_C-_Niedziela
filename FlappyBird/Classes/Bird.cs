using System.Numerics;

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
    // Stworzyć metodę, która będzie podbijała ptaka
    // Stworzyć metodą, która będzie sprawdzała kolizję z podłożem
    // Zastanaowić się, jak może wygląd budowa klasy rury, jak rozwiąć problem z wieloma rurami na planszy

    // Przygotować grafikę flappybird'a

}