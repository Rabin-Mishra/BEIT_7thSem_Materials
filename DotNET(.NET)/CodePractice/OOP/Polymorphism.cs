using System;  // Importing the System namespace for basic functionalities like Console I/O.

// Base class 'Shape' representing a generic shape.
public class Shape
{
    // Virtual method 'Show' that can be overridden by derived classes.
    // This is an example of **runtime polymorphism** (method overriding).
    public virtual void Show()
    {
        Console.WriteLine("Show the shape");  // Default behavior for showing a shape.
    }
}

// Derived class 'Circle' that inherits from 'Shape'.
public class Circle : Shape
{
    // Override the 'Show' method to provide specific implementation for 'Circle'.
    // This demonstrates **runtime polymorphism** (method overriding).
    public override void Show()
    {
        Console.WriteLine("Show this overridden class itself");  // Display a specific message for Circle.
    }
}

// Class 'Calculator' demonstrating **compile-time polymorphism** using method overloading.
public class Calculator
{
    // Overloaded method for adding two integers. 
    // The appropriate method is chosen at compile time based on the argument types.
    public int Add(int a, int b)
    {
        return a + b;  // Adds two integers.
    }

    // Overloaded method for adding two double values.
    // This method is called when the arguments are of type double.
    public double Add(double a, double b)
    {
        return a + b;  // Adds two double numbers.
    }
}

class Program
{
    // Main method, which is the entry point for the program.
    static void Main(string[] args)
    {
        // Demonstrating **runtime polymorphism**: 
        // Creating an object of type 'Circle' but referring to it with a base class 'Shape'.
        // The 'Show' method will call the overridden version in the 'Circle' class.
        Shape S1 = new Circle();  // Polymorphic reference: base class reference pointing to derived class object.
        S1.Show();  // Output: "Show this overridden class itself" (Runtime polymorphism occurs here).

        // Demonstrating **compile-time polymorphism**: 
        // The 'Add' method is overloaded with different parameter types (int and double).
        Calculator C = new Calculator();

        // Calls the 'Add(int, int)' method, as both arguments are integers.
        Console.WriteLine("The added sum of integer is " + C.Add(2, 3));  // Output: "The added sum of integer is 5"

        // Calls the 'Add(double, double)' method, as both arguments are doubles.
        Console.WriteLine("The added sum of double is " + C.Add(2.2, 3.2));  // Output: "The added sum of double is 5.4"
    }
}
