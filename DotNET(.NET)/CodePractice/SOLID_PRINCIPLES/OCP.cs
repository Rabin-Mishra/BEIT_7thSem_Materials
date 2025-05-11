using System;

// Interface for shapes requiring an Area method
// This makes it easy to add new shapes without modifying existing code, adhering to the Open/Closed Principle.
public interface IShape
{
    double Area();
}

// Circle class implementing IShape
// New shape types (like Circle) can be added without changing the IShape interface or any other code.
public class Circle : IShape
{
    public double R;

    // Area calculation for Circle
    public double Area()
    {
        return Math.PI * R * R;
    }
}

// Rectangle class implementing IShape
// Rectangle is a new shape added, but no changes are needed to the IShape interface or other classes.
public class Rect : IShape
{
    public double W, H;

    // Area calculation for Rectangle
    public double Area()
    {
        return W * H;
    }
}

class Program
{
    static void Main()
    {
        // Create Circle and Rectangle instances
        // These new shapes can be created and used without modifying the program's main logic.
        IShape C = new Circle() { R = 5 };
        IShape R = new Rect() { W = 4, H = 5 };
        
        // Output areas
        Console.WriteLine("Circle Area is " + C.Area());
        Console.WriteLine("Rectangle Area is " + R.Area());
    }
}
/*
 2. Open/Closed Principle (OCP):
 • The Area() method in IShape interface allows adding new shapes
 (like Circle, Rect) without modifying existing classes.
*/