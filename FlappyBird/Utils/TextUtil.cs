using Raylib_cs;

public static class TextUtil
{
    public static void CenterDrawText(string text, int fontSize, Color color, int offsetY = 0)
    {
        int textWidth = Raylib.MeasureText(text, fontSize);
        int x = (Constants.WINDOW_WIDTH - textWidth) / 2;
        int y = ((Constants.WINDOW_HEIGHT - fontSize) / 2) + offsetY;

        Raylib.DrawText(text, x, y, fontSize, color);
    }
}