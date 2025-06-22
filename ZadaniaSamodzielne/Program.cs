using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        /*
        Napisz funkcję w C#, która przyjmie jako argument ciąg znaków (string) i zwróci ten
        ciąg znaków odwrócony. Na przykład, jeśli funkcja otrzyma jako argument "Hello,
        World!", powinna zwrócić "!dlroW ,olleH".

        string ReverseString(string input)

        */

        Console.WriteLine(StringUtil.FastReverseStringByForLoop("Hello World!"));

        /*

        Napisz funkcję w C#, która przyjmie dwa ciągi znaków i sprawdzi, czy są one
        anagramami. Anagramy to słowa lub frazy, które zawierają te same litery, ale w innej
        kolejności. Ignorujemy wielkość liter.

        Sygnatura funkcji: bool AreAnagrams(string str1, string str2)

        */

        Console.WriteLine(StringUtil.AreAnagrams("napad", "panda"));
        Console.WriteLine(StringUtil.AreAnagrams("pands", "napad"));
        Console.WriteLine(StringUtil.AreAnagrams("panda", "napsd"));
        /*
        Napisz program w C# używający biblioteki Raylib, który wyświetli
        parę oczu na środku okna. Oczy powinny być w formie okręgów, gdzie większy okrąg
        reprezentuje gałkę oczną, a mniejszy okrąg wewnątrz większego reprezentuje
        źrenicę. Źrenice powinny być umieszczone w środku gałek ocznych.
        */

        // var game = new Game();
        // game.Init();
        // game.Play();

        var game = new AnimationGame();
        game.Init();
        game.Play();
    }


}