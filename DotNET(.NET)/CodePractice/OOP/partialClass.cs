using System; // Import the System namespace, which provides basic functionalities like Console I/O.

// Define a partial class 'Person'. A partial class allows the definition of a class across multiple files.
public partial class Person
{
    // Define a property 'Name' with getter and setter.
    // 'get' allows access to the value, and 'set' allows modification of the value.
    public string Name { get; set; }
}

// Define another partial class 'Person' (this can be in a different file, but it’s allowed in the same file too).
public partial class Person
{
    // Define a property 'Age' with getter and setter.
    public int Age { get; set; }

    // Define a method 'Introduce' to introduce the person.
    // It uses the Name and Age properties to print a message to the console.
    public void Introduce()
    {
        Console.WriteLine($"Hi, I am {Name} and I am {Age} years old");
    }
}

// Main program where execution starts.
class Program
{
    // Entry point of the program (Main method).
    static void Main(string[] args)
    {
        // Create a new instance of the 'Person' class.
        Person P = new Person();

        // Set the 'Name' property of the Person object to "Rabin".
        P.Name = "Rabin";

        // Set the 'Age' property of the Person object to 20.
        P.Age = 20;

        // Call the 'Introduce' method on the Person object to print the introduction message to the console.
        P.Introduce(); // Outputs: "Hi, I am Rabin and I am 20 years old"
    }
}
