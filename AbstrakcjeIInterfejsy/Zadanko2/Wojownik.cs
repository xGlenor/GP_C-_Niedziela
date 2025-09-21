using System;

namespace AbstrakcjeIInterfejsy.Zadanko2;

public class Wojownik : Postac, IBohater
{
    public Wojownik(string nazwa, int hp)
    {
        _nazwa = nazwa;
        _hp = hp;
    }

    public void Walcz()
    {
        Console.WriteLine("Wojownik tnie mieczem!");
    }

    public override void PrzedstawSie()
    {
        Console.WriteLine($"Jestem {_nazwa} i jestem Wojownikiem. Mam {_hp} punktów życia.");
    }

}
