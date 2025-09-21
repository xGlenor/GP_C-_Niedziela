public class MatematykaTesty
{

    [Fact]
    public void Dodaj_DwieLiczby_ZwracaPoprawnyWynik()
    {
        //Przygotowanie
        var matma = new Matematyka();
        int liczba1 = 3;
        int liczba2 = 5;

        //Wykonanie
        int wynik = matma.Dodaj(liczba1, liczba2);

        //Weryfikowanie
        Assert.Equal(8, wynik);
    }

    [Theory]
    [InlineData(3, 5, 8)]
    [InlineData(0, 5, 5)]
    [InlineData(-2, 7, 5)]
    [InlineData(-3, -2, -5)]
    public void Dodaj_DwieLiczby_ZwracaPoprawnyWynik_2(int liczba1, int liczba2, int oczekiwany)
    {
        //Przygotowanie
        var matma = new Matematyka();

        //Wykonanie
        int wynik = matma.Dodaj(liczba1, liczba2);

        //Weryfikowanie
        Assert.Equal(oczekiwany, wynik);
    }

}
