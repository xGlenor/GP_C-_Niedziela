using Microsoft.ML.Data;

public class Film
{
    [LoadColumn(0)]
    public string Tytul { get; set; }

    [LoadColumn(1)]
    public string Gatunek { get; set; }

    [LoadColumn(2)]
    public bool Lubiany { get; set; }

    [LoadColumn(3)]
    public float Rok { get; set; }

    [LoadColumn(4)]
    public float Ocena { get; set; }

    [LoadColumn(5)]
    public string Rezyser { get; set; }
}