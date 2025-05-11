using System;

// Interface for work-related behavior
// This interface defines a contract for the work functionality, allowing classes that need to perform work to implement it.
public interface IWork
{
    void Work();
}

// Interface for eating behavior
// This interface defines a contract for the eat functionality, ensuring classes that need to eat can implement it.
public interface IEat
{
    void Eat();
}

// Human class implements both IWork and IEat
// Humans perform both work and eating actions, so they implement both interfaces.
public class Human : IWork, IEat
{
    public void Work()
    {
        Console.WriteLine("Humans work");
    }

    public void Eat()
    {
        Console.WriteLine("Humans Eat");
    }
}

// Robot class implements only IWork
// Robots only perform work, so they implement the IWork interface, adhering to ISP by avoiding unnecessary functionality.
public class Robot : IWork
{
    public void Work()
    {
        Console.WriteLine("Robots Work");
    }
}

class Program
{
    static void Main()
    {
        // **ISP Example**: Interfaces are segregated, and classes only implement relevant behaviors.
        
        // Human object implements both work and eat functionality
        IWork W = new Human();
        W.Work();  // Humans work
        
        IEat E = new Human();
        E.Eat();   // Humans eat
        
        // Robot object implements only work functionality
        IWork R = new Robot();
        R.Work();  // Robots work (no unnecessary "Eat" method here)
    }
}
/*
 4. Interface Segregation Principle (ISP):
 • IWork and IRest are segregated, so classes only implement the meth
ods they actually need.
*/