using System;

namespace LINQ;

public class Student
{
    public string Imie { get; set; }
    public int Wiek { get; set; }
    public float Srednia { get; set; }

    public static List<Student> Studenci => new List<Student>
    {
        new Student() {Imie = "Grześ", Wiek = 23, Srednia = 4.9f},
        new Student() {Imie = "Zbychu", Wiek = 40, Srednia = 2.4f},
        new Student() {Imie = "Marta", Wiek = 76, Srednia = 6.0f},
        new Student() {Imie = "Karolina", Wiek = 17, Srednia = 3.4f },
        new Student() {Imie = "Zbychu", Wiek = 19, Srednia = 5.2f}
    };

    public static void Run()
    {
        // Więcej niż jeden warunek
        var pofiltrowaniStudenci = Studenci.Where(s => s.Wiek > 20 && s.Srednia > 5.0f).ToList();

        var pofiltrowaniStudenci2 = (from student in Studenci
                                     where student.Wiek > 20 &&
                                        student.Srednia > 5
                                     select student
                                     ).ToList();

        pofiltrowaniStudenci.ForEach(n => Console.Write($"{n.Imie}, "));
        Console.WriteLine();

        pofiltrowaniStudenci2.ForEach(n => Console.Write($"{n.Imie}, "));
        Console.WriteLine();

    }

}
