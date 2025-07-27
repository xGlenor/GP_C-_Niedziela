using System.Text;
using GraWZycie;


int[,] szybowiec = new int[3, 3]
{
    {0, 1, 0},
    {0, 0, 1},
    {1, 1, 1}
};

int[,] kaczucha = new int[5, 5]
{
    {0,0,0,0,0},
    {0,0,1,1,0},
    {1,1,0,1,1},
    {1,1,1,1,0},
    {0,1,1,0,0}
};


Siatka siatkaSzybowca = new Siatka(szybowiec, 20, 20);
Siatka siatkaKaczucha = new Siatka(kaczucha, 20, 20);


Console.WriteLine("Wybierz rodzaj gry:");
Console.WriteLine(" 0 -> Okienkowa");
Console.WriteLine(" 1 -> Konsolowa");
Console.WriteLine(" 2 -> Koniec");

Console.Write("Twój wybór: ");
int wybor = int.Parse(Console.ReadLine() ?? "0");

Console.Clear();

switch (wybor)
{
    case 1:
        Gra gra = new Gra(20, 20, 1);
        gra.Uruchom(100);
        break;
    case 0:
        GraRaylib graRaylib = new GraRaylib();
        graRaylib.Inicjalizuj();
        graRaylib.Uruchom();
        break;
    case 2:
    default:
        return;
}

