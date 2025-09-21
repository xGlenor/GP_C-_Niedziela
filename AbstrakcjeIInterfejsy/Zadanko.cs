// Scenariusz: „Zwierzęta w wirtualnym zoo grające w orkiestrze”.

// 1. Klasa abstrakcyjna Zwierze z metodą abstrakcyjną WydajDzwiek() i zwykłą Oddychaj().
// 2. Interfejs IGraNaInstrumencie z metodą Graj().
// 3. Klasa PapugaMuzyczna dziedziczy z Papuga (która dziedziczy z Zwierze) i
// (jednocześnie) implementuje IGraNaInstrumencie.

public abstract class Zwierze
{
    public abstract void WydajDzwiek();

    public void Oddychaj()
    {
        Console.WriteLine("Zwierze oddycha.");
    }
}

public interface IGraNaInstrumencie
{
    public void Graj();
}

public class Papuga : Zwierze
{
    public override void WydajDzwiek()
    {
        Console.WriteLine("Papuga mówi: hej!");
    }

}

public class PapugaMuzyczna : Papuga, IGraNaInstrumencie
{
    public void Graj()
    {
        Console.WriteLine($"Papuga gra na cymbałkach");
    }
}

public class Zadanko1()
{
    public static void Main()
    {
        PapugaMuzyczna papugaMuzyczna = new PapugaMuzyczna();
        papugaMuzyczna.Oddychaj();
        papugaMuzyczna.WydajDzwiek();
        papugaMuzyczna.Graj();
    }
}