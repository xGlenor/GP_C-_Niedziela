using System.Numerics;
using Raylib_cs;

public class PipeManager
{
    private const int pipeWidth = 80;
    private const int spawnInterval = 90;
    private int screenWidth;
    private int screenHeight;
    private List<Pipe> pipes;
    private int frameCounter;
    private Color pipeColor;
    private bool passed;
    public List<Pipe> Pipes => pipes;

    public PipeManager()
    {
        this.screenWidth = Constants.WINDOW_WIDTH;
        this.screenHeight = Constants.WINDOW_HEIGHT;
        this.pipeColor = Color.Green;
        pipes = new List<Pipe>();
        frameCounter = 0;
    }

    private void AddPipe()
    {
        int pipeGap = Raylib.GetRandomValue(150, 250);
        int pipeHeight = Raylib.GetRandomValue(100, screenHeight - pipeGap - 100);
        Vector2 pipePosition = new Vector2(screenWidth, 0);

        pipes.Add(new Pipe(pipePosition, pipeWidth, pipeHeight, pipeGap, pipeColor));
    }

    public void Update()
    {
        frameCounter++;

        if (frameCounter >= spawnInterval)
        {
            AddPipe();

            frameCounter = 0;
        }

        for (int i = pipes.Count - 1; i >= 0; i--)
        {
            pipes[i].Update();
            if (pipes[i].IsOffScreen())
            {
                pipes.RemoveAt(i);
            }
        }
    }

    public int AddPoint(int score)
    {
        foreach (var pipe in pipes)
        {
            if (pipe.Position.X <= (screenWidth / 4) &&
            (pipe.Position.X + pipeWidth) >= (screenWidth / 4))

            {
                if (!pipe.Passed)
                {
                    pipe.Passed = true;
                    score += 1;
                }
            }
        }
        return score;
    }

    public void Draw()
    {
        foreach (var pipe in pipes)
        {
            pipe.Draw();
        }
    }

    public bool CheckCollision(Vector2 birdPosition)
    {
        foreach(var pipe in Pipes)
        {
            if (pipe.CheckCollision(birdPosition)) return true;
        }

        return false;
    }
}