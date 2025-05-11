// Abstract class with an abstract method
public abstract class Shape
{
    // Abstract method with no implementation
    public abstract void Draw();
}

// Concrete class (derived class)
public class Circle : Shape
{
    // Implementing the abstract method
    public override void Draw()
    {
        Console.WriteLine("Drawing a Circle.");
    }
}

// Main program to demonstrate the abstract class
class Program
{
    static void Main(string[] args)
    {
        Shape myShape = new Circle();  // Circle is a concrete class inheriting Shape
        myShape.Draw();  // Calls the Draw method of Circle class
    }
}
