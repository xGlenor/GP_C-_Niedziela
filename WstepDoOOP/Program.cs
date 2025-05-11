
// string imie = "Burek";
// string gatunek = "Labrador"; 

// Console.WriteLine($"Cześć, jestem {imie} i jestem gatunkiem {gatunek}!");

// // Stworzenie nowego obiektu klasy Pies (słówko do zapamiętania new)
// Pies pies = new Pies();

// // Przypisywanie wartości do pól obiektu
// pies.imie = "Aron";
// pies.gatunek = "Labrador";

// // Wywołanie metody "Powitanie" z klasy Pies
// pies.Powitanie();

// pies.ZjedzChrupke(10);
// pies.ZjedzChrupke(10, "Scooby chrupki");


/*
Napisz aplikację konsolową, której zadaniem będzie zasymulowanie działania silnika.
Program powinien zawierać klasę silnik, która posiadać będzie dwie cechę –
prywatną cechę moc oraz publiczną cechę CzyWlaczony. Dodatkowo w klasie
należy dodać dwie metody do manipulowania wartością moc: ZmniejszMoc i
ZwiększMoc. Metody powinny zmieniać wartość mocy i wyświetlać komunikat o jej
obecnym stanie tylko, gdy silnik jest włączony. Jeżeli nastąpi próba zmiany mocy
przy wyłączonym silniku powinien zostać wyświetlony komunikat. 

*/



Silnik silnik= new Silnik();
silnik.ZmienMoc(10);
silnik.ZmienMoc(20);
silnik.ZmienMoc(-5);
silnik.ZmienMoc(-10);
silnik.czyWlaczony = true;
silnik.ZmienMoc(10);
silnik.ZmienMoc(20);
silnik.ZmienMoc(-5);
silnik.ZmienMoc(-10);



Console.ReadKey();