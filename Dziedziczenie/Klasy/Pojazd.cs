public class Pojazd {

    public int Moc;
    public string Kolor;
    public string Marka;

    public Pojazd() {
        
    }

    public Pojazd(int moc, string kolor, string marka){
        Moc = moc;
        Kolor = kolor;
        Marka = marka;
    }

    public virtual void UruchomSilnik() {
        Console.WriteLine("Silnik pojazdu uruchomiony...");
    }

    public override string ToString() {
        return $"Marka: {Marka} | Kolor {Kolor}";
    }
}