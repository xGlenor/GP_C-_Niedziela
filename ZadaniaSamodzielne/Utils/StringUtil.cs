using System.Text;

public static class StringUtil
{
    public static string ReverseStringByArrayReverse(string input)
    {
        //Tablicą charów -> łańuch znaków(string)
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public static string ReverseStringByForLoop(string input)
    {
        string reversed = "";
        for (int i = 0; i < input.Length; i++)
        {
            reversed += input[input.Length - 1 - i];
        }

        return reversed;
    }

    public static string FastReverseStringByForLoop(string input)
    {
        StringBuilder builder = new StringBuilder(input.Length);
        for (int i = input.Length - 1; i >= 0; i--)
            builder.Append(input[i]);
        return builder.ToString();
    }

    public static string ReverseStringByLINQ(string input)
    {
        return new string(input.Reverse().ToArray());
    }

    public static bool AreAnagrams(string str1, string str2)
    {
        // Długości musza być takie same
        if (str1.Length != str2.Length) return false;

        str1 = str1.ToLower().Replace(" ", "");
        str2 = str2.ToLower().Replace(" ", "");

        var str1_char = str1.ToArray();
        var str2_char = str2.ToArray();

        Array.Sort(str1_char);
        Array.Sort(str2_char);

        //Do usunięcia dla testów
        Console.WriteLine(new string(str1_char));
        Console.WriteLine(new string(str2_char));
        Console.WriteLine("");


        // for (int i = 0; i < str1_char.Length; i++)
        // {
        //     if (str1_char[i] != str2_char[i])
        //         return false;
        // }

        //return true;

        return str1_char.SequenceEqual(str2_char);
    }

}