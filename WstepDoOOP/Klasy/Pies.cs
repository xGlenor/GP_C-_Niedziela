
public class Pies {

    // Zmienna dostępna wszedzie, nawet między projektami
    public int zmiennaPublic;
    
    // zmienna publiczna, ale tylko dla danego projektu (tego samego)
    internal int zmiennaIntrnal;

    // Zmiena prywatna dostępna, tylko w danej klasie
    private int zmiennaPrivate;

    //Zmienna chroniona, dostepna dla tej samej klasy i dla klas dziedziczących
    protected int zmiennaProtected;

    public string imie;
    public string gatunek;

    // Metoda -> Funkcja dotyczaca danej klasy
    public void Powitanie() {
        Console.WriteLine($"Cześć, jestem {imie} i jestem gatunkiem {gatunek}!");

    }

    public void ZjedzChrupke(int iloscChrupek){
        Console.WriteLine($"Mniam! Pyszne te Scooby Chrupki wsunąłem {iloscChrupek}");
    }


    public void ZjedzChrupke(int iloscChrupek, string jakieChrupki) {
        Console.WriteLine($"Mniam! Pyszne te chrupki wsunąłem ich {iloscChrupek}. Fajne te {jakieChrupki}");
    }

}