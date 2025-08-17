
using Microsoft.EntityFrameworkCore;

using (var context = new AppDbContext())
{
    Console.Clear();
    context.Database.EnsureDeleted();
    context.Database.EnsureCreated();

    // CREATE: Dodanie nowego wydawcy i gry do Bazy danych
    var wydawca = new Wydawca() { Nazwa = "CD Projket Red" };

    var gra = new Gra()
    {
        Tytul = "Cyberpunk 2077",
        Gatunek = "Akcja",
        RokWydania = 2020,
        Wydawca = wydawca
    };

    await context.Publisher.AddAsync(wydawca);
    await context.Games.AddAsync(gra);
    await context.SaveChangesAsync();
    Console.WriteLine($"Dodano nowego wydawcę i grę {gra.Tytul}");

    // SELECT
    await SelectGames(context);

    //UPDATE: Aktualizacja istniejącej gry
    var graDoAktualizacji = await context.Games.FirstAsync();
    graDoAktualizacji.Gatunek = "Akcja-Przygoda";
    await context.SaveChangesAsync();
    Console.WriteLine("Zaktualizowani Gatunek w pierwszej grze");
    await SelectGames(context);

    //DELETE: Usuwanie gry z bazy danych
    var graDoUsuniecia = await context.Games.FirstAsync();
    context.Games.Remove(graDoUsuniecia);
    await context.SaveChangesAsync();
    Console.WriteLine("Usunięto grę z bazy danych");
    await SelectGames(context);

    //RAW SQL: Wykonanie zapytania SQL
    var dodanaGra = context.Database
        .ExecuteSqlRaw("INSERT INTO Games VALUES ('The Sims 5', 'Symulotor', 2026, 1)");
    Console.WriteLine($"Ilość dodanych gier: {dodanaGra}");
    await SelectGames(context);

    //Wzorzec Repository
    var repoPub = new Repository<Wydawca>(context);
    var repoGame = new Repository<Gra>(context);

    var wyd1 = new Wydawca() { Nazwa = "EA Sports" };

    await repoPub.AddAsync(wyd1);
    await repoGame.AddAsync(new Gra()
    {
        Tytul = " Fifa 2025",
        Gatunek = "Sport",
        RokWydania = 2025,
        Wydawca = wyd1
    });

    var gryLista = await repoGame.GetAllAsync();
    foreach (var game in gryLista)
    {
        Console.WriteLine(game);
    }

}

static async Task SelectGames(AppDbContext context)
{
    //SELECT: Odczytywanie wszystkich giert z filtrowaniem i sortowaniem
    var gry = await context.Games // Z tabeli Games
            .Include(g => g.Wydawca) // Dołączenie wydawcy z tabeli Publisher
            .Where(g => g.RokWydania >= 2020) // Gry, które powstało po i w 2020 roku
            .OrderBy(g => g.Tytul) // Posortuj alfabetycznie po tytule gry
            .ToListAsync(); // Konwertuj do Listy<Gra>

    // Wyświetlenie w Konsole
    gry.ForEach(Console.WriteLine);
}