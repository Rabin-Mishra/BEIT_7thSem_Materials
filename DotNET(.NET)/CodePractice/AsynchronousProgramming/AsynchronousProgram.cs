using System;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Task.Run(async () => await callMethod()).Wait(); // Run async task in a blocking way.
        Console.ReadKey();
    }

    public static async Task callMethod()
    {
        Method2();
        var count = await Method1();
        Method3(count);
    }

    public static async Task<int> Method1()
    {
        int count = 0;
        await Task.Run(() =>
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Method 1");
                count += 1;
            }
        });
        return count;
    }

    public static void Method2()
    {
        Console.WriteLine("Method 2");
    }

    public static void Method3(int count)
    {
        Console.WriteLine($"Method 3 - Count: {count}");
    }
}
