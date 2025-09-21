using AbstrakcjeIInterfejsy.Abstrakcja;
using AbstrakcjeIInterfejsy.Zadanko2;

// Stworzyć obiekt typu Zombie i wywołać
// metodę MakeSound
var zombie = new Zombie("Franek", 20);
zombie.MakeSound();

// Ale również możemy stworzyć obiekt typu Zombie z obiektu bazowego Entity, dziedziczączego. 
// (Dopełniając klasę abstrakcyjną Entity implementacją z klasy Zombie)
// Jednak, gdy klasa Zombie będzie miała własne metody, nie będą one widoczne dla Entity
Entity zombie1 = new Zombie("Jacek", 30);
zombie1.MakeSound();



// Scenariusz: „Zwierzęta w wirtualnym zoo grające w orkiestrze”.

// 1. Klasa abstrakcyjna Zwierze z metodą abstrakcyjną WydajDzwiek() i zwykłą Oddychaj().
// 2. Interfejs IGraNaInstrumencie z metodą Graj().
// 3. Klasa PapugaMuzyczna dziedziczy z Papuga (która dziedziczy z Zwierze) i
// (jednocześnie) implementuje IGraNaInstrumencie.

Zadanko1.Main();
Zadanko2.Main();