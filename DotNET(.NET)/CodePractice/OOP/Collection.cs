using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4 };
        numbers.Add(5);
        Console.WriteLine(numbers[2]);
    }
}