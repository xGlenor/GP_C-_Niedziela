using Raylib_cs;

public static class RayLibUtils
{
    public static void DrawEyes(int centerX, int centerY, int eyeRadius, int pupilRadius)
    {
        Raylib.DrawCircle(centerX, centerY, eyeRadius, Color.White);

        Raylib.DrawCircle(centerX, centerY, pupilRadius, Color.Black);
    }
}