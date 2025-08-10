public class Adres
{
    public string Ulica { get; set; }
    public string FullUlica => $"ul. {Ulica}";

    public int MyProperty { get; private set; }

}

