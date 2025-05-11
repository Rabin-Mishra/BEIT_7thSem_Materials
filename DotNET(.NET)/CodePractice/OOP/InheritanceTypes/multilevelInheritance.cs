using System;  // Importing the System namespace to use Console for input/output operations.

/// <summary>
/// Base class representing a generic animal. This class contains common behaviors
/// that are shared by all animals, such as the ability to eat.
/// </summary>
public class Animal
{
    // Method representing the behavior of eating, which is common to all animals.
    public void Eat()
    {
        Console.WriteLine("Animal Eats");  // Output message indicating the animal is eating.
    }
}

/// <summary>
/// Derived class from Animal, representing a Dog. Inherits behavior from Animal.
/// The Dog class adds specific behavior such as barking, which is unique to dogs.
/// </summary>
public class Dog : Animal
{
    // Method representing the behavior of barking, specific to dogs.
    public void Bark()
    {
        Console.WriteLine("Dog Barks");  // Output message indicating the dog is barking.
    }
}

/// <summary>
/// Derived class from Dog, representing a Puppy. Inherits behavior from both Dog and Animal.
/// The Puppy class adds specific behavior such as playing, which is unique to puppies.
/// </summary>
public class Puppy : Dog
{
    // Method representing the behavior of playing, specific to puppies.
    public void Play()
    {
        Console.WriteLine("Puppy is playing");  // Output message indicating the puppy is playing.
    }
}

class Program
{
    // Main entry point of the application. It is where the program starts execution.
    static void Main(string[] args)
    {
        // Create an object of the 'Puppy' class.
        // A Puppy is a type of Dog, and a Dog is a type of Animal, so it can access all inherited behaviors.
        Puppy P = new Puppy();

        // Calling the 'Eat' method inherited from the 'Animal' class.
        P.Eat();  // Output: "Animal Eats" - Demonstrates that Puppy has inherited the 'Eat' method.

        // Calling the 'Bark' method inherited from the 'Dog' class.
        P.Bark();  // Output: "Dog Barks" - Demonstrates that Puppy has inherited the 'Bark' method.

        // Calling the 'Play' method, which is specific to the 'Puppy' class.
        P.Play();  // Output: "Puppy is playing" - Shows the Puppy-specific behavior that is not inherited by Dog or Animal.
    }
}
