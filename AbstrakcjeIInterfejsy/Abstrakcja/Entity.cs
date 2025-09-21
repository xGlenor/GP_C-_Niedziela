using System;

namespace AbstrakcjeIInterfejsy.Abstrakcja;

public abstract class Entity
{
    public string Name { get; set; }
    public int Health { get; set; }


    // Każde Entity, może się poruszać. Więc jest to wspólna implementacja dla klas pochodnych (dziedziczących)
    public void Move()
    {
        Console.WriteLine($"{Name} przesuwa się po świecie");
    }

    // Każdy Entity może wydawać dzwięk, ale jaki? To już zależy od konkretnej klasy, która
    // dziedziczy po klasie abstrakcyjnej Entity
    public abstract void MakeSound();

}
