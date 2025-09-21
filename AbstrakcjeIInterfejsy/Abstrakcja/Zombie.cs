using System;

namespace AbstrakcjeIInterfejsy.Abstrakcja;

public class Zombie : Entity
{

    public Zombie(string Name, int Health) : base()
    {
        this.Name = Name;
        this.Health = Health;
    }

    // Zombie implementuje mechanizm wydawania dzwięku, który narzuca mu klasa Entity
    public override void MakeSound()
    {
        Console.WriteLine("Zombie jęczy...");
    }
}
