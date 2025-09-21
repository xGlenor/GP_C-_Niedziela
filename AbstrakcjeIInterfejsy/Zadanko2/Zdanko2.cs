using System;

namespace AbstrakcjeIInterfejsy.Zadanko2;

public class Zadanko2
{
    public static void Main()
    {

        Wojownik woj = new Wojownik("Ragnar", 100);
        Mag mag = new Mag("Merlin", 80);

        woj.PrzedstawSie();
        mag.PrzedstawSie();

        Random rand = new Random();

        mag.Walcz();
        woj.Walcz();

        // while (woj._hp >= 0 || mag._hp >= 0)
        // {

        // }


    }
}
