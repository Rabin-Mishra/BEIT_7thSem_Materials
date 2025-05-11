using System; // Importing the System namespace, which provides basic functionalities like Console I/O.

// Define a static class 'Calc' that contains mathematical helper functions.
public static class Calc
{
    // Define a static method 'Square' that calculates the square of an integer.
    // The 'static' keyword means this method belongs to the class itself, not to an instance of the class.
    public static int Square(int n)
    {
        // Return the square of the input number 'n' (n * n).
        return n * n;
    }
}

class Program
{
    // Entry point of the program (Main method).
    static void Main(string[] args)
    {
        // Call the 'Square' method from the 'Calc' class to calculate the square of 5.
        // Since 'Square' is a static method, it can be called directly on the class 'Calc' without creating an instance of the class.
        int res = Calc.Square(5);

        // Print the result to the console, displaying the squared value of 5.
        Console.WriteLine("The value of squared number 5 is " + res);
    }
}
