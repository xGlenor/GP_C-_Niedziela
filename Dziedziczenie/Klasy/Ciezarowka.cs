
public class Ciezarowka : Pojazd{

    public int LadownoscPrzyczepy;

    public Ciezarowka(int moc, string kolor, string marka, int ladownoscPrzyczepy) : base(moc, kolor, marka){
        LadownoscPrzyczepy = ladownoscPrzyczepy;
    }

    public void UruchomSilnik() {
        Console.WriteLine("Silnik ciezarowki uruchomiony...");
    }
}