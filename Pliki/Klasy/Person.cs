public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Address Address { get; set; }
    public List<string> Skills { get; set; }
    public List<WorkExperience> WorkExperience { get; set; }

}

public class WorkExperience
{
    public string Company { get; set; }
    public int Years { get; set; }
}

public class Address
{
    public string City { get; set; }
    public string Street { get; set; }
    public int Number { get; set; }
}