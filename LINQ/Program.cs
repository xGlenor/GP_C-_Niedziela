using LINQ;

List<int> liczby = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

foreach (var liczba in liczby)
{
    if (liczba % 2 == 0)
        Console.WriteLine(liczba);
}

// Przeszukiwanie/filtrowanie warunkowe (TYLKO LICZBY PARZYSTE)

var parzyste = liczby.Where(n => n % 2 == 0).ToList();

parzyste.ForEach(Console.WriteLine);

var tescik = liczby.Where(n =>
{
    if (n == 2) return false; // Pomijamy liczbę 2, jeśli wystapi

    return n % 2 == 0;

}).ToList();

// Zamiast wyrażenia lambda, przekazujemy funkcję
var parzysteZFunkcji = liczby.Where(CzyParzysta).ToList();

static bool CzyParzysta(int number)
{
    return number % 2 == 0;
}

// Dwa Rodzaje składni LINQ
// Składnia Metod
var wynik = liczby.Where(n => n % 2 == 0).ToList();

// Składnia Zapytań
var wynik2 = (from x in liczby where x % 2 == 0 select x).ToList();


//Filtrowanie Where()
List<int> liczby1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var liczby_parzyste = liczby1.Where(n => n % 2 == 0).ToList();

// Sortowanie OrderBy, OrderByDescending
List<string> imiona = new List<string> { "Anna", "Wojtek", "Zbysiu", "Agnieszka" };
var posortowaneImiona = imiona.OrderBy(imie => imie).ToList();
var posortowaneImionaMalejaco = imiona.OrderByDescending(imie => imie).ToList();

posortowaneImiona.ForEach(n => Console.Write($"{n}, "));
Console.WriteLine("");
posortowaneImionaMalejaco.ForEach(n => Console.Write($"{n}, "));
Console.WriteLine();
// Agregacja danych Sum, Min, Max, Average
var oceny = new List<int> { 4, 3, 2, 1, 5, 6 };

var suma = oceny.Sum();
var min = oceny.Min();
var max = oceny.Max();
var srednia = oceny.Average();

Console.WriteLine($"Suma: {suma} | Min: {min} | Max: {max} | Srednia: {srednia}");

// Klasa Student, która będzie miałą 3 właściwości Imie, Wiek i Srednia

Student.Run();

var studenci = Student.Studenci;

var najlepszyStudent = studenci.OrderByDescending(s => s.Srednia).FirstOrDefault();

if (najlepszyStudent != null)
{
    Console.WriteLine($"Najelepszy student: {najlepszyStudent.Imie} Srednia: {najlepszyStudent.Srednia}");
}

var czyIstniejeMaciek = studenci.Where(n => n.Equals("Maciek")).FirstOrDefault();

var czyIstnieje = czyIstniejeMaciek != null ? "Tak" : "Nie";

Console.WriteLine($"Czy Maciek wciaż studiuje? {czyIstnieje}");

// Pobieranie unikalnych imion
var studenciImiona = studenci.Select(n => n.Imie).ToList(); // Z duplikatami

Console.WriteLine(string.Join(',', studenciImiona));

var studenciImionaUnikalni = studenci.Select(n => n.Imie).Distinct().ToList();
Console.WriteLine(string.Join(',', studenciImiona));