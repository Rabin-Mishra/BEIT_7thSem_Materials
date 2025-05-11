using System;

// Interface for device operations
// High-level module (Switch) depends on this abstraction (IDevice) rather than concrete classes.
public interface IDevice
{
    void On();
    void Off();
}

// Bulb class implements IDevice
// Low-level module (Bulb) implements the IDevice interface, providing the specific behavior for turning the bulb on and off.
public class Bulb : IDevice
{
    public void On()
    {
        Console.WriteLine("Bulb ON");
    }

    public void Off()
    {
        Console.WriteLine("Bulb Off");
    }
}

// Switch class depends on the abstraction (IDevice), not the concrete Bulb class
// The Switch can operate any device that implements IDevice, adhering to DIP.
public class Switch
{
    private readonly IDevice _d;

    // Constructor injection: Switch class depends on IDevice abstraction
    public Switch(IDevice d)
    {
        _d = d;
    }

    // Operate the device (turn it on)
    // The Switch can operate any device that implements IDevice, whether it's a Bulb, Fan, etc.
    public void Operate()
    {
        _d.On();
    }
}

class Program
{
    static void Main()
    {
        // **DIP Example**: High-level module (Switch) depends on the abstraction (IDevice), not a specific device implementation (Bulb).

        IDevice B = new Bulb();       // Low-level module (Bulb) implements the abstraction (IDevice)
        Switch S = new Switch(B);     // Switch depends on IDevice abstraction
        S.Operate();                  // Switch operates the Bulb via the IDevice interface
    }
}
/*
 5. Dependency Inversion Principle (DIP):
 • Switch depends on the IDevice abstraction, which allows for easy
 replacement of devices (e.g., Bulb).
*/