using System; // Importing the System namespace to use basic .NET functionalities (e.g., Console).

// Define an abstract base class 'Shape'.
public abstract class Shape
{
    // Declare an abstract method 'Draw', which must be implemented by any derived class.
    public abstract void Draw();
}

// Define a derived class 'Circle' that inherits from 'Shape'.
public class Circle : Shape
{
    // Override the 'Draw' method from the 'Shape' class to provide a specific implementation for 'Circle'.
    public override void Draw()
    {
        // Print a message to the console indicating that a circle is being drawn.
        Console.WriteLine("Draw a circle");
    }
}

class Program
{
    // Entry point of the program
    static void Main(string[] args)
    {
        // Create a 'Circle' object, but refer to it using the base class type 'Shape'.
        Shape S1 = new Circle(); // This demonstrates polymorphism: we use a parent class reference to point to a child class object.

        // Call the 'Draw' method on the 'Shape' reference, which will execute the overridden version in the 'Circle' class.
        S1.Draw(); // This will print "Draw a circle" because 'S1' refers to an instance of 'Circle'.
    }
}
