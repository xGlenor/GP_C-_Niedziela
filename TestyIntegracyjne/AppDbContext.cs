using Microsoft.EntityFrameworkCore;

class AppDbContext : DbContext
{

    public DbSet<Produkt> Produkty { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

}