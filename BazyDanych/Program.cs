using BazyDanych;

using (var context = new AppDbContext())
{
    context.Database.EnsureCreated();

    // // Tworzenie Użytkownika
    // var user = new User() { Username = "Grześ", Password = "grzes123" };

    // // Dodawanie Użytkownika
    // context.Users.Add(user);

    // // Zapisywanie dodanego użytkownika (ogólnie doknanych zmian na bazie)
    // context.SaveChanges();

    var list = new List<Student>() {
        new() { Name = "Harry", House = "Gryffindor" },
        new() { Name = "Ron", House = "Gryffindor" },
        new() { Name = "Hermione", House = "Gryffindor" },
        new() { Name = "Malfoy", House = "Slytherin" }
    };

    context.Students.AddRange(list);
    context.SaveChanges();

    // Odczytywanie użytkowników
    var users = context.Students.ToList();

    users.ForEach(u =>
    {
        Console.WriteLine(u.ToString());
    });

    context.Database.EnsureDeleted();

}
