using System;

interface IAnimal
{
    void animalSound();
}
class Pig : IAnimal
{
    public void animalSound()
    {
        Console.WriteLine("The pig says: wee wee");
    }
}
//main program
class Program
{
    static void Main()
    {
        Pig P = new Pig();
        P.animalSound();//output: The pig says: wee wee
    }
}