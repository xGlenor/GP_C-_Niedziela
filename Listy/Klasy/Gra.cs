public class Gra {

    private string Nazwa;
    private decimal Cena;

    public Gra(string nazwa, decimal cena) 
    {
        Nazwa = nazwa;
        Cena = cena;
    }

    public override string ToString() {
        return $"Gra '{Nazwa}' kosztuje {Cena} zł";
    }

}