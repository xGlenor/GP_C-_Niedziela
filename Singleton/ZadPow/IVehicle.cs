using System;

namespace Singleton.ZadPow;

public interface IVehicle
{
    int MaxSpeed { get; set; }
    void Drive();
}
