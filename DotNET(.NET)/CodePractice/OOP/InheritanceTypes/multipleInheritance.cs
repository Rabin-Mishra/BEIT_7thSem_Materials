/*
. Multiple Inheritance (through Interfaces):
In C#, multiple inheritance is achieved through interfaces, as a class can implement multiple interfaces.
*/
using System;
public interface IAnimal
{
    void Eat();  // Interface method for eating behavior
}

public interface IDomestic
{
    void Play();  // Interface method for playing behavior
}

public class Dog : IAnimal, IDomestic
{
    public void Eat()
    {
        Console.WriteLine("Dog is eating");  // Implementing IAnimal's Eat method
    }
    public void Play()
    {
        Console.WriteLine("Dog is playing");  // Implementing IDomestic's Play method
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog D = new Dog();
        D.Eat();  // Calls Eat() from IAnimal
        D.Play(); // Calls Play() from IDomestic
    }
}
