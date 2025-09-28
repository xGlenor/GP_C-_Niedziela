using System;

namespace Singleton;

public class Kalkulator
{
    public void Test()
    {
        Console.WriteLine("W Klasie Kalkulator");

        Console.WriteLine($"Pierwsze wywołanie Increment(): {Counter.Instance.Increment()}");
        Console.WriteLine($"Drugie wywołanie Increment(): {Counter.Instance.Increment()}");
        Console.WriteLine($"Aktualny stan licznika: {Counter.Instance.CurrentValue}");

    }
}
