
public class Gigant {

    private int Id;
    public string Imie;
    protected int wiek;

    public int Wiek {
        get => wiek;
        set => wiek = value;
    }

    // Konstruktor domyślny
    public Gigant() {

    }

    // Konstruktor z dwoma parametrami
    public Gigant(string imie, int wiek) {
        Id = new Random().Next(0, 1000);
        Imie = imie;
        this.wiek = wiek;
    }

    // Konstruktor z trzema parametrami
    public Gigant(int id, string imie, int wiek) {
        Id = id;
        Imie = imie;
        this.wiek = wiek;
    }

    public void Przywitanie(){
        Console.WriteLine($"ID: {Id} | Imię: {Imie} | Wiek: {Wiek}");
    }

}




