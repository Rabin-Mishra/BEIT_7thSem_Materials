using System;

public class Parent
{
    // Virtual method that can be overridden in derived classes (runtime polymorphism)
    public virtual string Eat()
    {
        return "Eat Rice";
    }

    public virtual string Play()
    {
        return "Play Football";
    }
}

public class Child : Parent
{
    // Overriding the Eat method in Child class (runtime polymorphism)
    public override string Eat()
    {
        return "Eat Pizza";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Parent reference pointing to a Child object
        Parent p = new Child();

        // Demonstrating runtime polymorphism: the overridden Eat method in Child will be called
        Console.WriteLine(p.Eat());  // Output: Eat Pizza

        // Play method is not overridden in Child, so Parent's Play method will be called
        Console.WriteLine(p.Play());  // Output: Play Football
    }
}
