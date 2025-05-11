using System; // Importing the System namespace, which provides basic functionalities like Console for I/O.

// Define an abstract class 'Shape'. 
// Abstract classes cannot be instantiated directly, but they can define abstract methods that must be implemented by derived classes.
public abstract class Shape
{
    // Abstract method 'Draw' with no implementation in the base class.
    // Any derived class (like 'Circle') must provide its own implementation of 'Draw'.
    public abstract void Draw();

    // Virtual method 'Show' that has a default implementation in the base class.
    // Derived classes can override this method to provide a custom implementation.
    public virtual void Show()
    {
        // Default implementation prints a message about showing the shape.
        Console.WriteLine("Show Shape");
    }
}

// Define a class 'Circle' that inherits from 'Shape' and provides specific implementations for the abstract methods.
public class Circle : Shape
{
    // Override the 'Draw' method to provide a specific implementation for 'Circle'.
    // This method will print "Draw circle" when called.
    public override void Draw()
    {
        Console.WriteLine("Draw circle");
    }

    // Override the 'Show' method to provide a custom implementation for 'Circle'.
    // This version prints a different message compared to the base class 'Show'.
    public override void Show()
    {
        Console.WriteLine("Show this overridden statement itself");
    }
}

class Program
{
    // Entry point of the application (Main method).
    static void Main(string[] args)
    {
        // Create a 'Circle' object but reference it with the base class type 'Shape'.
        // This demonstrates polymorphism, where the base class reference can point to a derived class object.
        Shape S1 = new Circle();

        // Call the 'Draw' method. Since 'S1' is a reference to a 'Circle' object,
        // it will invoke the overridden 'Draw' method in the 'Circle' class.
        S1.Draw();  // Output: "Draw circle"

        // Call the 'Show' method. Even though 'S1' is of type 'Shape', it will invoke the overridden
        // 'Show' method in the 'Circle' class because 'Show' is overridden in 'Circle'.
        S1.Show();  // Output: "Show this overridden statement itself"
    }
}
