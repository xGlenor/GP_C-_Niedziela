
public class Pisak {

    public string Kolor;
    public int Grubosc;
    public decimal Cena;


    public Pisak()
    {
        Kolor = "Testowy Kolor";
        Grubosc = 0;
        Cena = 0m;
    }

    public Pisak(string kolor, int grubosc, decimal cena)
    {
        Kolor = kolor;
        Grubosc = grubosc;
        Cena = cena;
    }

    public void WypiszInformacje(){
        Console.WriteLine("Informacje o pisaku: ");
        Console.WriteLine($"\tKolor: {Kolor}");
        Console.WriteLine($"\tGrubosc: {Grubosc}");
        Console.WriteLine($"\tCena: {Cena}zł");
    }

}