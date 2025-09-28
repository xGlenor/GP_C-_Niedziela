using Singleton;
using Singleton.ZadPow;

/* 
Zadanie powtórzeniowe

1. Stwórz interfejs IVehicle, który zawiera:
  ● Właściwość maxSpeed (typu int).
  ● Metodę Drive() (bez implementacji).
2. Stwórz abstrakcyjną klasę VehicleBase, która będzie zawierać:
  ● Publiczną zmienną name (typu string).
  ● Abstrakcyjną metodę StartEngine() (bez implementacji).
3. Zaimplementuj klasę Car, która:
  ● Dziedziczy po VehicleBase.
  ● Implementuje interfejs IVehicle.
  ● Zaimplementuje metodę StartEngine() z klasy bazowej.
  ● Zaimplementuje metody i właściwosć z IVehicle: maxSpeed oraz Drive().
 */

Car.Main();

Console.WriteLine($"Pierwsze wywołanie Increment(): {Counter.Instance.Increment()}");
Console.WriteLine($"Drugie wywołanie Increment(): {Counter.Instance.Increment()}");
Console.WriteLine($"Aktualny stan licznika: {Counter.Instance.CurrentValue}");


var reference = Counter.Instance;

Console.WriteLine($"Kolejne wywołanie Increment(): {reference.Increment()}");
Console.WriteLine($"Kolejne wywołanie Increment(): {reference.Increment()}");
Console.WriteLine($"Aktualny stan licznika: {reference.CurrentValue}");