// Base class - Parent class
public class Parent
{
    // Virtual method allows child classes to override this behavior
    public virtual string Eat()
    {
        return "Eat Rice";  // Default behavior (Eat Rice)
    }

    // Virtual method that can be overridden by derived classes
    public virtual string Play()
    {
        return "Play Football";  // Default behavior (Play Football)
    }
}

// Derived class - Child class inherits from Parent class
public class Child : Parent
{
    // Method overrides the Eat() method of the Parent class
    public override string Eat()
    {
        return "Eat MOMO";  // New behavior in Child class (Eat MOMO)
    }
}

// Main program where execution begins
class Program
{
    static void Main()
    {
        // Create a Parent reference, but assign it a Child object
        Parent P = new Child();

        // Create a Parent object directly
        Parent P1 = new Parent();

        // Since P is a Parent reference, but actually points to a Child object,
        // polymorphism ensures the overridden version of Eat() in Child is called.
        Console.WriteLine(P.Eat());  // Outputs "Eat MOMO" due to polymorphism

        // Play() method is not overridden in Child, so the Parent's implementation is called
        Console.WriteLine(P.Play());  // Outputs "Play Football" (default from Parent)

        // P1 is a direct instance of the Parent class, so the Parent's implementation is used
        Console.WriteLine(P1.Eat());  // Outputs "Eat Rice" (default from Parent)
    }
}
