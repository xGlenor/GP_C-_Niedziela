using System;
using Microsoft.EntityFrameworkCore;

namespace BazyDanych;

public class AppDbContext : DbContext
{

    public DbSet<User> Users { get; set; }
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=uzytkownicy;Trusted_Connection=True;TrustServerCertificate=True;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<Student>().HasData(
        //     new Student { Id = 1, Name = "Harry", House = "Gryffindor" },
        //     new Student { Id = 2, Name = "Ron", House = "Gryffindor" },
        //     new Student { Id = 3, Name = "Hermione", House = "Gryffindor" },
        //     new Student { Id = 4, Name = "Malfoy", House = "Slytherin" }
        // );
        base.OnModelCreating(modelBuilder);
    }

}
