var osoba1 = new Osoba("Grześ", 23);
var osoba2 = new Osoba("Grześ", 23);

// TRUE, bo porównuje wartości rekordu
//Console.WriteLine(osoba1 == osoba2); 
// FALSE, bo porównuje obiekty
//Console.WriteLine(ReferenceEquals(osoba1, osoba2));

// Zmiana wartość jest niemożliwa, bo obiekt jest
// niemutowalny
//osoba1.imie = "Siema";
Console.WriteLine("=== SŁOWNIKI ===");
Dictionary<int, string> giganci = new Dictionary<int, string>();

//Dodawanie elementów do słownika
giganci.Add(1, "Grześ");
giganci.Add(2, "Bartosz");
giganci.Add(3, "Jan B");
giganci.Add(4, "Jan M");

//Wyświetlenie elementów
foreach (var gigant in giganci)
{
    Console.WriteLine($"ID: {gigant.Key}, Imie: {gigant.Value}");
}

// Dostęp do elementów słownika

int klucz = 2;
if (giganci.ContainsKey(klucz))
{
    string imie = giganci[klucz];
    System.Console.WriteLine(imie);

    // Aktualizacja wartości
    giganci[klucz] = "Martyna";
    Console.WriteLine(giganci[klucz]);
}

//Usuwanie elementów
giganci.Remove(2);

///

Console.WriteLine("=== KOLEJKI ===");

//Tworzenie
Queue<string> zadania = new Queue<string>();

//Dodawanie elementów do kolejki
zadania.Enqueue("Zrób śniadanie");
zadania.Enqueue("Umyj zęby");
zadania.Enqueue("Idź do szkoły/pracy");
zadania.Enqueue("Idź spać");

//Wyświetalnie elementów w kolejce
foreach (var task in zadania)
{
    Console.WriteLine($"{task}");
}

// Usuwanie elementów (obsługa pierwszego elementu z kolejki)
var task1 = zadania.Dequeue();
Console.WriteLine($"Zadanie 1: {task1}");

//Sprawdzenie pierwszego elementu kolejki
var checkTaskQueue = zadania.Peek();
Console.WriteLine($"Kolejny element w kolejce: {checkTaskQueue}");

Console.WriteLine("=== HASHSET ===");

//Tworzenie
HashSet<int> numery = new HashSet<int>();

//Dodawnie
numery.Add(1);
numery.Add(2);
numery.Add(3);

//Próba dodania duplikatu
bool dodane = numery.Add(2);
Console.WriteLine($"Czy udało się dodać nr. 2? {dodane}");

// Usuwanie elementu z hashsetu
bool usuniety = numery.Remove(2);
Console.WriteLine($"Czy element nr. 2 został usunięty? {usuniety}");

Console.WriteLine("=== OPERACJE NA ZBIORACH ===");

HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5 };
HashSet<int> set2 = new HashSet<int>          { 4, 5, 6, 7, 8 };

//Suma zbiorów
// set1.UnionWith(set2);
// Console.WriteLine("Suma: " + string.Join(",", set1));

//Różnica zbiorów
//set1.ExceptWith(set2);
//Console.WriteLine("Różnica: " + string.Join(",", set1));

//Część Wspólna
set1.IntersectWith(set2);
Console.WriteLine("Część Wspólna: " + string.Join(",", set1));
