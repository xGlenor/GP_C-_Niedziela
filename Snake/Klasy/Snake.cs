using System.Numerics;
using Raylib_cs;

public class Snake
{
    private int gridSize;
    private int widthScreen;
    private int heightScreen;

    private Vector2 direction;
    private List<Vector2> body;
    private Color colorSnake;
    private bool isGrowing;

    public Snake(int gridSize, int widthScreen, int heightScreen)
    {
        this.gridSize = gridSize;
        this.widthScreen = widthScreen;
        this.heightScreen = heightScreen;

        body = new List<Vector2>();
        body.Add(new Vector2(widthScreen / 2, heightScreen / 2));

        RandomColorSnake();
        direction = new Vector2(1, 0);
        isGrowing = false;
    }

    public void Move()
    {
        var headSnake = body[0];
        var newHeadSnake = new Vector2(
            headSnake.X + direction.X * gridSize,
            headSnake.Y + direction.Y * gridSize
        );

        if (isGrowing)
        {
            body.Insert(0, newHeadSnake);
            isGrowing = false;
        }
        else
        {
            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i] = body[i - 1];
            }

            body[0] = newHeadSnake;
        }

        Vector2 updatedHeadSnake = body[0];

        if (updatedHeadSnake.X >= widthScreen) updatedHeadSnake.X = 0; // Right
        if (updatedHeadSnake.X < 0) updatedHeadSnake.X = widthScreen - gridSize; // Left

        if (updatedHeadSnake.Y >= heightScreen) updatedHeadSnake.Y = 0; // Bottom
        if (updatedHeadSnake.Y < 0) updatedHeadSnake.Y = heightScreen - gridSize; // Top

        body[0] = updatedHeadSnake;
    }

    public void Grow()
    {
        isGrowing = true;
    }

    public void ChangeDirection(Vector2 newDirection)
    {
        if ((direction.X + newDirection.X != 0) || (direction.Y + newDirection.Y != 0))
        {
            direction = newDirection;
        }
    }

    public void Draw()
    {
        foreach (var segment in body)
        {
            Raylib.DrawRectangleV(segment, new Vector2(gridSize, gridSize), colorSnake);

            //Raylib.DrawRectangle((int)segment.X, (int)segment.Y, gridSize, gridSize, Color.Green);
        }
    }

    public bool CheckCollision(Vector2 position)
    {
        foreach (var segment in body)
        {
            if (segment == position)
                return true;
        }
        return false;
    }

    public bool CheckSelfCollision()
    {
        Vector2 head = body[0];
        for (int i = 1; i < body.Count; i++)
        {
            if (body[i] == head)
                return true;
        }
        return false;
    }

    // Metoda, która zmienia węża w losowy kolor z tablicy colors w ColorUtil
    public void RandomColorSnake()
    {
        Random random = new Random();
        int indexColor = random.Next(0, ColorUtil.colors.Length - 1);
        colorSnake = ColorUtil.colors[indexColor];
    }

    // Metoda, która zmienia segmenty węża losowo z tablicy colors w ColorUtil
    public Color ReturnRandomColorSnake()
    {
        Random random = new Random();
        int indexColor = random.Next(0, ColorUtil.colors.Length - 1);
        return ColorUtil.colors[indexColor];
    }
}