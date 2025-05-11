// Klasa SamochodOsobowy dziedziczy po klasie Pojazd (czyli przejmuje jego cechy, właściwości
// zgodnie z modyfikatorami dostępu)
public class SamochodOsobowy : Pojazd {

    public SamochodOsobowy(int moc, string kolor, string marka) : base(moc, kolor, marka) {
        
    }

    public void UruchomSilnik() {
        Console.WriteLine("Silnik samochodu uruchomiony...");
    }
}