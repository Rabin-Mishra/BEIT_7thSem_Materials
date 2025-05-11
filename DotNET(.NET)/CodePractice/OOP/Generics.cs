using System;

class DataStore<T>
{
    public T Data { get; set; }
}

class Program
{
    static void Main()
    {
        DataStore<int> store = new DataStore<int>();
        store.Data = 10;
        Console.WriteLine(store.Data);//output: 10
    }
}