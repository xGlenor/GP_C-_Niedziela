using System.Numerics;
using Raylib_cs;

public class Food
{
    public Vector2 Position { get; private set; }

    private int gridSize;
    private int widthScreen;
    private int heightScreen;

    public Food(int heightScreen, int widthScreen, int gridSize)
    {
        this.heightScreen = heightScreen;
        this.widthScreen = widthScreen;
        this.gridSize = gridSize;

        GenerateNewPosition();
    }

    public void GenerateNewPosition()
    {
        Random random = new Random();

        int x = random.Next(0, widthScreen / gridSize) * gridSize;
        int y = random.Next(0, heightScreen / gridSize) * gridSize;

        Position = new Vector2(x, y);
    }

    public void Draw()
    {
        Raylib.DrawRectangleV(Position, new Vector2(gridSize, gridSize), Color.DarkPurple);
    }
}