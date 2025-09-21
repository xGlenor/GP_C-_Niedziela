using System;
using AbstrakcjeIInterfejsy.Abstrakcja;

namespace AbstrakcjeIInterfejsy.Interfejsy;

public class Creeper : Entity, IExplode
{
    // Implementacje metody MakeSound z Entity
    public override void MakeSound()
    {
        Console.WriteLine("Creeper syczy...");
    }

    // Wypełniamy umowę z interfejsem IExplode
    public void Explosion()
    {
        Console.WriteLine("Creeper wybucha zadaje obrażenia");
    }

    public void Kolizja(string gracz)
    {
        // Jeżeli gracz podchodzi do creepera (LOGIKA)
        Explosion(); // Creeper wybucha i zadaje obrażenia
        //Zadaj obrazenia z gracza
    }



}
