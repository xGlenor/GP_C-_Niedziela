using System;
using System.Security.Cryptography.X509Certificates;

namespace AbstrakcjeIInterfejsy.Zadanko2;

public class Mag : Postac, IBohater
{

    public Mag(string nazwa, int hp)
    {
        _nazwa = nazwa;
        _hp = hp;
    }

    public void Walcz()
    {
        Console.WriteLine("Mag rzuca zaklęcie");
    }

    public override void PrzedstawSie()
    {
        Console.WriteLine($"Jestem {_nazwa} i jestem magiem. Mam {_hp} punktów życia");
    }

}
