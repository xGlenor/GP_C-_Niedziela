public class Osoba {

    public static int LicznikOsob = 0;
    public static int Licznik2 {get; private set;} = 0;

    string Imie;
    string Nazwisko;

    public Osoba(string imie, string nazwisko)
    {
        Imie = imie;
        Nazwisko = nazwisko;
    
        Console.WriteLine($"Stworzono osobę {Imie} {Nazwisko}");
        // Podczas tworzenia new obiektu, zwiększamy licznik o 1
        LicznikOsob++;
        Licznik2++;

    }

    public static void WyswietlLicznikOsob() {
        Console.WriteLine($"Aktualny stan osób: {LicznikOsob}");
    }

}