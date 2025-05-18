public class GeneratorPostaci {

    private Random LiczbyLosowe;

    public GeneratorPostaci()
    {
        LiczbyLosowe = new Random();
    }

    public Mag GenereujMaga() {
        int hp = LiczbyLosowe.Next(150, 300);
        int atak = LiczbyLosowe.Next(5, 15);
        string imie = "Veigar";

        return new Mag(imie, hp, atak, 10);
    }

    public Wojownik GenerujWojownika() {
        int hp = LiczbyLosowe.Next(150, 300);
        int atak = LiczbyLosowe.Next(5, 15);
        string imie = "Garen";

        return new Wojownik(imie, hp, atak, 5);
    }

}