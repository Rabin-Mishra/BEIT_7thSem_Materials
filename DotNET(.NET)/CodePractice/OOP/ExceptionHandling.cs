using System;  // Import the System namespace, which provides essential classes like Console, Convert, etc.

class Program  // Define a class named 'Program' which contains the Main method (entry point of the program).
{
    static void Main(string[] args)  // Define the Main method, which is the entry point for the application.
    {
        try  // Start a try block to attempt code that may throw an exception.
        {
            Console.WriteLine("Enter the number to divide");  // Print a message asking the user to enter a number.

            // Read user input from the console and attempt to convert it to an integer.
            int num = Convert.ToInt32(Console.ReadLine());  // Convert the string input to an integer. This may throw a FormatException if the input is not a valid number.

            // Perform the division operation. This may throw a DivideByZeroException if the user enters '0'.
            int res = 10 / num;  // Attempt to divide 10 by the user's input.

            // If no exception occurs, output the result of the division.
            Console.WriteLine("Result obtained is " + res);  // Print the result of the division to the console.
        }
        catch (DivideByZeroException ex)  // Catch a specific exception that occurs when dividing by zero.
        {
            // If division by zero happens, this block is executed.
            Console.WriteLine("Error can't divide by zero" + ex.Message);  // Print a message explaining the error, and include the exception's message.
        }
        catch (FormatException ex)  // Catch a FormatException, which happens if the user enters an invalid number format.
        {
            // If the user input is not a valid number, this block will be executed.
            Console.WriteLine("Format Exception " + ex.Message);  // Print the error message from the exception.
        }
        catch (Exception ex)  // Catch any other general exceptions that might occur.
        {
            // If any unexpected exception occurs, this block is executed.
            Console.WriteLine("General Exception occured" + ex.Message);  // Print a general error message with the exception details.
        }
        finally  // Finally block is always executed, whether an exception occurs or not.
        {
            Console.WriteLine("Finally block has been executed");  // Indicate that the finally block is executed (cleanup code or final messages go here).
        }
    }
}
