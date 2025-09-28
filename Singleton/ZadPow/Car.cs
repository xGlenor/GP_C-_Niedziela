using System;

namespace Singleton.ZadPow;

public class Car : VehicleBase, IVehicle
{
    public int MaxSpeed { get; set; }

    public Car(string name, int maxSpeed)
    {
        Name = name;
        MaxSpeed = maxSpeed;
    }

    public override void StartEngine()
    {
        Console.WriteLine("Włączono silnik");
    }

    public void Drive()
    {
        Console.WriteLine("Samochód jedzie...");
    }

    public static void Main()
    {
        Car car = new Car("Volvo", 320);

        car.StartEngine();
        car.Drive();
    }
}
