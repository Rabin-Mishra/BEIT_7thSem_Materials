using System;

// Class for managing user data
// This class has a single responsibility: managing user information.
public class User
{
    public string Name;

    // Save user data
    // The Save method only handles saving user-related data, maintaining a single responsibility.
    public void Save()
    {
        Console.WriteLine("User saved.");
    }
}

// Class for logging
// This class has a single responsibility: logging actions.
public class Log
{
    // Log user actions
    // The Write method is dedicated solely to logging actions, not mixing with user data.
    public void Write()
    {
        Console.WriteLine("Action logged.");
    }
}

class Program
{
    static void Main()
    {
        // **SRP Example**: Each class has a clear, focused responsibility
        User U = new User { Name = "Rabin" };
        Log L = new Log();

        U.Save();  // User class handles only user data saving
        L.Write(); // Log class handles only action logging
    }
}
/*
 1. Single Responsibility Principle (SRP):
 • TheUser class manages user data, and the Log class handles logging.
 Each class has a single responsibility.
*/
