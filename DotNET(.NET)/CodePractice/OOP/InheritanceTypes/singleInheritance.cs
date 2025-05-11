using System;  // Importing the System namespace to use Console functionality for I/O.

// Base class 'Animal' that represents a general animal.
public class Animal
{
    // Method 'Eat' in the Animal class that represents an action that an animal can perform.
    // This method can be inherited by any class that derives from Animal.
    public void Eat()
    {
        Console.WriteLine("Animal is eating");  // Output to show the action of eating.
    }
}

// Derived class 'Dog' that inherits from 'Animal'.
// The 'Dog' class is a more specific type of Animal.
public class Dog : Animal
{
    // Method 'Bark' specific to the Dog class.
    // This method is not inherited from Animal; it's unique to the Dog class.
    public void Bark()
    {
        Console.WriteLine("Dog Barks");  // Output to show the dog barking.
    }
}

class Program
{
    // Main method where the program starts execution.
    static void Main(string[] args)
    {
        // Create an object of type 'Dog'.
        // Since 'Dog' is a subclass of 'Animal', we can access methods from both Animal and Dog.
        Dog D = new Dog();

        // Call the 'Eat' method, which is inherited from the Animal class.
        D.Eat();  // Output: "Animal is eating" (this method is inherited from Animal)

        // Call the 'Bark' method, which is specific to the Dog class.
        D.Bark();  // Output: "Dog Barks" (this method is defined only in the Dog class)
    }
}
