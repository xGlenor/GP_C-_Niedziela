using Microsoft.EntityFrameworkCore;

public class ProduktTestyIntegracyjne : IDisposable
{

    private readonly AppDbContext _context;

    public ProduktTestyIntegracyjne()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        _context = new AppDbContext(options);

        _context.Produkty.Add(new Produkt { Nazwa = "Produkt Testowy 1", Cena = 10.99m });
        _context.Produkty.Add(new Produkt { Nazwa = "Produkt Testowy 2", Cena = 20.99m });
        _context.SaveChanges();
    }

    [Fact]
    public void Czy_Mozna_Pobrac_Produkty()
    {
        //Wykonanie
        var produkty = _context.Produkty.ToList();

        //Sprawdzenie
        Assert.Equal(2, produkty.Count());
        Assert.Contains(produkty, p => p.Nazwa == "Produkt Testowy 1");
        Assert.Contains(produkty, p => p.Nazwa == "Produkt Testowy 2");
    }

    public void Dispose()
    {
        _context.Database.EnsureDeleted();
        _context.Dispose();
    }

}