public class Autobus : Pojazd {

    public int IloscOsob;

    public Autobus(int moc, string kolor, string marka, int iloscOsob) : base(moc, kolor, marka){
        IloscOsob = iloscOsob;
    }

    public override void UruchomSilnik() {
        Console.WriteLine("Silnik autobusu uruchomiony...");
    }
}