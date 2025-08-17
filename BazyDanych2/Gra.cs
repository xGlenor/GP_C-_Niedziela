public class Gra
{
    public int Id { get; set; }
    public string Tytul { get; set; }
    public string Gatunek { get; set; }
    public int RokWydania { get; set; }
    public Wydawca Wydawca { get; set; }

    public override string ToString()
    {
        return $"Tytuł: {Tytul} | Gatunek: {Gatunek} | Wydawca: {Wydawca.Nazwa} | Rok Wyd: {RokWydania}";
    }
}