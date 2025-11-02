// string path = "testowyPlik2.txt";

// if (!File.Exists(path))
// {
//     File.Create(path).Dispose();
//     Console.WriteLine($"Plik {path} nie istniał, ale został stworzony");
//     File.WriteAllLines(path, ["Ala ma", "Kota", "Pozdrawiam gigantów"]);
//     return;
// }

// string[] lines = File.ReadAllLines(path);
// foreach (var line in lines)
// {
//     Console.WriteLine(line);
// }

using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;

string jsonPath = "people.json";

try
{
    var jsonString = File.ReadAllText(jsonPath);

    List<Person> people = JsonSerializer.Deserialize<List<Person>>(jsonString);

    if (people == null)
    {
        Console.WriteLine("Błąd: Brak danych w pliku");
        return;
    }

    foreach (var person in people)
    {
        if (string.IsNullOrWhiteSpace(person.Name))
        {
            Console.WriteLine("Błąd: Brak imienia danej osoby");
            return;
        }

        Console.WriteLine($"--- {person.Name} ---");
        Console.WriteLine($" Age: {person.Age}");
        Console.WriteLine($" City: {person.Address.City}, Street: {person.Address.Street} {person.Address.Number}");

        Console.WriteLine(" Skills:");
        if (person.Skills != null)
        {
            person.Skills.ForEach(skill => Console.WriteLine($"  - {skill}"));
        }

        // WorkExperience
        // Zabezpieczyć wyświetlanie osób za pomocą walidacji

    }


}
catch (Exception ex)
{
    Console.WriteLine($"Błąd podczas odczytywania pliku JSON: {ex.Message}");
}

Console.WriteLine("JAKIŚ TEKST");

var adres = new Address()
{
    City = "Warszawa",
    Street = "Krucza",
    Number = 45
};

var workExperience = new List<WorkExperience>
{
    new WorkExperience() {Company = "Giganci Programowania", Years = 2},
    new WorkExperience() {Company = "Zespół Technicznych i Leśnych", Years = 0}
};

var zbyszek = new Person()
{
    Name = "Zbyszek",
    Age = 24,
    Skills = new List<string> { "C#", "Python", "HTML", "CSS" },
    WorkExperience = workExperience,
    Address = adres
};

var jsonOptions = new JsonSerializerOptions()
{
    WriteIndented = true,
    Encoder = JavaScriptEncoder.Create(System.Text.Unicode.UnicodeRanges.All)
};

var zbyszekString = JsonSerializer.Serialize(zbyszek, jsonOptions);
Console.WriteLine(zbyszekString);

File.WriteAllText("osoba.json", zbyszekString, Encoding.UTF8);