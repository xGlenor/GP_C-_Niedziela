using Raylib_cs;

public static class TextUtil
{
    public static void CenterDrawText(string text, int fontSize,int offsetX = 0, int offsetY = 0)
    {
        int textWidth = Raylib.MeasureText(text, fontSize);
        int x = (Constants.WINDOW_WIDTH - textWidth) / 2;
        int y = (Constants.WINDOW_HEIGHT - fontSize) / 2;
        
    }
}