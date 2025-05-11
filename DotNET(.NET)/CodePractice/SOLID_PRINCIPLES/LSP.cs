using System;

// Base class Bird
// This class provides a general behavior (Move) for birds, which can be overridden by specific types of birds.
public class Bird
{
    // Method to move the bird, to be overridden by derived classes
    // The default behavior is flying.
    public virtual void Move()
    {
        Console.WriteLine("Flying");
    }
}

// Derived class Sparrow, inheriting from Bird
// This class overrides the Move method to provide a more specific behavior for a Sparrow.
public class Spar : Bird
{
    // Overriding the Move method to specify the behavior for a Sparrow
    public override void Move()
    {
        Console.WriteLine("Sparrow Flying");
    }
}

// Derived class Ostrich, inheriting from Bird
// This class overrides the Move method to provide a different behavior for an Ostrich.
public class Ostr : Bird
{
    // Overriding the Move method to specify the behavior for an Ostrich
    public override void Move()
    {
        Console.WriteLine("Ostrich Running");
    }
}

class Program
{
    static void Main()
    {
        // **LSP Example**: Substituting derived classes for the base class
        Bird S = new Spar();  // Sparrow is a type of Bird
        Bird O = new Ostr();  // Ostrich is also a type of Bird
        
        S.Move();  // Sparrow will print "Sparrow Flying"
        O.Move();  // Ostrich will print "Ostrich Running"
    }
}

/*
 Liskov Substitution Principle (LSP):
 • Derived classes Spar and Ostr can substitute their base class Bird
 without breaking the behavior.
*/