/* int[] liczby = new int[5];
liczby[0] = 4;
Console.WriteLine(liczby[0]); */

// Zadanie: Napisać program konsolowy, który będzie prosił użytkownika o podawanie
// kolejno liczb całkowitych, zapisywał je w tablicy i wyświetlał za każdym razem
// zawartość tablicy i średnią podanych ocen. Dodać metodę ZamienNaTekst, która
// przyjmie tablicę i zwróci ją w postaci tekstu: [el1, el2, el3].


// Inicjalizacja listy
// List<int> oceny = new List<int>();

// double suma = 0;
// while (true)
// {
//     Console.WriteLine("Podaj nową ocenę: ");
//     int ocena = int.Parse(Console.ReadLine());

//     oceny.Add(ocena); // Dodawanie elementów do listy ocen
//     suma += ocena;


//     // każdorazowo wyświetlamy tablicę i aktualną średnią
//     string tekst = ZamienNaTekst2(oceny);

//     int liczbaElementow = oceny.Count;
//     double srednia = suma / oceny.Count;
//     Console.WriteLine($"Aktualna tablica: {tekst}");
//     Console.WriteLine($"Jest {liczbaElementow} liczb, średnia to {srednia}");
// }



// static string ZamienNaTekst(List<int> oceny)
// {
//     string wynik = "[ ";
//     for (int i = 0; i < oceny.Count; i++)
//     {
//         wynik += $"{oceny[i]} ";
//     }
//     wynik += "]";
//     return wynik;
// }

// static string ZamienNaTekst2(List<int> oceny) {

//     string wynik = "[ ";

//     foreach (int ocena in oceny) {
//         wynik += $"{ocena} ";
//     }

//     wynik += "]";
//     return wynik;
// }

// // 1 sposób tworzenia listy
// List<string> zakupy = new List<string>();
// zakupy.Add("Długopis"); 
// zakupy.Add("Piórnik");
// zakupy.Add("Samochód");

// // 2 sposób tworzenia listy
// List<int> liczby = new List<int>() { 1, 2, 3};
// List<int> liczby1 = new List<int> { 1, 2, 3};

// // 3 sposób tworzenia listy
// List<string> zakupy2 = ["Długopis", "Piórnik", "Samochód"];

// //Dodawanie elementów
// zakupy2.Add("Myszka");

// //Usuwanie elementów
// zakupy2.Remove("Piórnik"); // Po nazwie
// zakupy2.RemoveAt(0); // Po indeksie

// // Wyszukiwanie elementu w tablicy
// bool czyIstniejeSamochod =  zakupy2.Contains("Samochód"); // Czy znajduje się elementw liście
// int index = zakupy2.IndexOf("Myszka");


// Zadanie 2. Stworzyć listę, która będzie potrafiła przechowywać zmienne typu Gra.
// Następnie przeglądnąć listę gier po liście za pomocą nowo poznanej pętli i wyświetlić
// ceną oraz nazwę gry. Gra – jest to oczywiście klasa posiadająca dwie właściwości
// cena oraz nazwa. Właściwości te powinny być prywatne i ustawiane za pomocą
// konstruktora. Do wyświetlenia ceny i nazwy należy wykorzystać metodę ToString().

List<Gra> gry = new List<Gra>();

Gra fornite = new Gra("Fornite", 0);

gry.Add(fornite);

gry.Add(new Gra("Fifa", 250));
gry.Add(new Gra("CyberPunk", 300));

foreach (Gra g in gry) {
    Console.WriteLine(g);
}
