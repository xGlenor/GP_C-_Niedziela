using System;

namespace AbstrakcjeIInterfejsy.Interfejsy;

// Interfejs - Rodzaj kontraktu/ umowy, który klasa dziedzicząca po nim
// musi wypełnic (zaimplementować)
//
// Nazwy interfejsów piszemy w strukturze: INazwaInterfejsu
// Zapisujemy je wielką literą
// Interfejs ma domyslnie modyfikator dostępu PUBLIC
// Bardzo często interfejsy zapisujemy w osobnych plikach względem klas
public interface IExplode
{
    // Metody w interfejsach są bez ciała (bez implementacji)
    // Wskazują tylko, jaki rodzaj umowy/kontraktu ma być wykonany
    void Explosion();
}
