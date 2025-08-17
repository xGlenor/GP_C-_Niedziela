using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    // Zdefiniowanie dwóch tabel dla klasy Gra i Wydawca
    public DbSet<Gra> Games { get; set; }
    public DbSet<Wydawca> Publisher { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Baza SQL w Microsoft SQL Server
        optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=games;Trusted_Connection=True;TrustServerCertificate=True;");

        // Baza SQL w pliku
        //optionsBuilder.UseSqlite("Data Source=Games.db;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Stworzenie relacji między dwoma tabelami Gra i Wydawca
        modelBuilder.Entity<Wydawca>()
            // Wydawca zawiera wiele Gier
            .HasMany(wydawca => wydawca.Gry)
            // Gra zawiera jednego Wydawce
            .WithOne(gra => gra.Wydawca);
    }
}