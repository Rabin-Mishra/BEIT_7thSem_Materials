using System;

public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal Eats");
    }
}

public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog Barks");
    }
}

public class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Cat Meows");
    }
}

class Program
{
    static void Main()
    {
        // Dog object can access Animal's Eat method and Dog's specific Bark method
        Dog D = new Dog();
        D.Eat();  // Inherited from Animal
        D.Bark(); // Specific to Dog

        // Cat object can access Animal's Eat method and Cat's specific Meow method
        Cat C = new Cat();
        C.Eat();  // Inherited from Animal
        C.Meow(); // Specific to Cat
    }
}
