using System;

namespace BazyDanych;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string House { get; set; }

    public override string ToString()
    {
        return $"ID: {Id} Name: {Name} House: {House}";
    }
}
