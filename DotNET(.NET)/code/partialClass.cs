// File 1: Part of the class
public partial class Person
{
    public string Name { get; set; }
}

// File 2: Another part of the class
public partial class Person
{
    public int Age { get; set; }

    public void Introduce()
    {
        Console.WriteLine($"Hi, my name is {Name} and I am {Age} years old.");
    }
}

// Main program to demonstrate the partial class
class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.Name = "John";
        person.Age = 30;
        person.Introduce();
    }
}
