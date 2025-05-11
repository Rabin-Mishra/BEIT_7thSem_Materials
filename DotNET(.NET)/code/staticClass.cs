// Static class with static method
public static class MathUtility
{
    // Static method to calculate square of a number
    public static int Square(int number)
    {
        return number * number;
    }
}

// Main program to demonstrate the static class
class Program
{
    static void Main(string[] args)
    {
        int result = MathUtility.Square(5);  // Call static method directly from the class
        Console.WriteLine("Square of 5 is: " + result);
    }
}
