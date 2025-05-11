public class Butelka
{
    public string TypNapoju;
    public int AktualnaIloscNapoju;

    public void Wypij(int iloscDoWypicia)
    {
        if (AktualnaIloscNapoju < iloscDoWypicia)
        {
            Console.WriteLine("Za mało napoju w butelce");
        }
        else
        {
            AktualnaIloscNapoju -= iloscDoWypicia;
            Console.WriteLine($"Właśnie wypito {iloscDoWypicia} {TypNapoju}");
        }
    }
    public void SprawdzIlosc()
    {
        Console.WriteLine($"W butelce jest jeszcze {AktualnaIloscNapoju} ml{ TypNapoju}");
    }
}