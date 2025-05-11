using System;

public class Person
{
    public String Name;  // Field to store the person's name

    // Constructor to initialize the 'Name' field
    public Person(string name)
    {
        Name = name;  // Assign the passed 'name' to the 'Name' field
        Console.WriteLine("Constructor called");  // Indicates that the constructor has been executed
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an object of 'Person' and passing the name 'Rabin' to the constructor
        Person P = new Person("Rabin");
        Console.WriteLine("Name is: " + P.Name);  // Prints the value of 'Name' field
    }
}
