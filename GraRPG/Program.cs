

GeneratorPostaci gp = new GeneratorPostaci();

Console.WriteLine("Witaj w grze Wojownik vs Mag");

// Tworzymy gracza i przeciwnika
var gracz = gp.GenerujWojownika();
var przeciwnik = gp.GenereujMaga();

Console.WriteLine("Na swojej drodze spotkałeś przeciwnika: ");
przeciwnik.WyswietlStatystyki();

Console.WriteLine("Czy chcesz go zaatakować? (wpisz: atak) czy uciekać? wpisz (uczieczka)");

string odp = Console.ReadLine();
if (odp != "atak") {
    Console.WriteLine("Uciekasz...");
    Console.ReadKey();
}

Console.WriteLine("Do Ataku !!!");

while (przeciwnik.Hp >= 0 && gracz.Hp >= 0) {
    Console.WriteLine($"Gracz {przeciwnik.Nazwa} atakuje");
    int atakPrzeciwnika = przeciwnik.PobierzSileAtaku();
    gracz.OdjmijHp(atakPrzeciwnika);
    Console.WriteLine($"Pozostało ci {gracz.Hp} życia \n");

    if(gracz.Hp <= 0)
        break;

    Thread.Sleep(500);

    Console.WriteLine($"Gracz {gracz.Nazwa} atakuje.");
    int atakGracza = gracz.PobierzSileAtaku();
    przeciwnik.OdejmijHp(atakGracza);
    Console.WriteLine($"Przeciwnikowi zostało {przeciwnik.Hp} życia.\n");

    if (przeciwnik.Hp <= 0) 
        break;
    
    Thread.Sleep(500);

}

if (gracz.Hp <= 0) {
    Console.WriteLine($"Niestety zostałeś pokonany! Przeciwnik {przeciwnik.Nazwa} wygrał.");
}else {
    Console.WriteLine($"Gratulację! Pokonałeś przeciwnika {przeciwnik.Nazwa}");
}

Console.ReadKey();