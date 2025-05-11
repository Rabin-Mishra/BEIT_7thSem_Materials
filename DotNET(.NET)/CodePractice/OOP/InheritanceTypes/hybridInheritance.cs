/*
Hybrid Inheritance (Multiple Inheritance through Interfaces and Single Inheritance):
Combining single inheritance (Dog -> Puppy) with multiple interfaces (IAnimal, IPlay) for hybrid inheritance.
*/

using System;

public interface IAnimal
{
    void Eat();  // Interface method for animal's eating behavior
}

public interface IPlay
{
    void Play();  // Interface method for playing behavior
}

public class Dog : IAnimal, IPlay
{
    public void Eat()
    {
        Console.WriteLine("Dog is Eating");  // Implementing IAnimal's Eat method
    }
    public void Play()
    {
        Console.WriteLine("Dog is Playing");  // Implementing IPlay's Play method
    }
}

public class Puppy : Dog
{
    public void Fetch()
    {
        Console.WriteLine("Puppy is fetching");  // Puppy-specific behavior
    }
}

class Program
{
    static void Main(string[] args)
    {
        Puppy P = new Puppy();
        P.Eat();    // Inherited from Dog, which implements IAnimal
        P.Play();   // Inherited from Dog, which implements IPlay
        P.Fetch();  // Specific to Puppy class
    }
}
