using System;

class Program
{
    static void Main(string[] args)
    {
        string fullName = "Alice Johnson";
        int age = 22;

        Console.WriteLine($"Name: {fullName}");
        Console.WriteLine($"Length: {fullName.Length}");
        Console.WriteLine($"Upper: {fullName.ToUpper()}");
        Console.WriteLine($"Contains 'John': {fullName.Contains("John")}");

        string[] parts = fullName.Split(' ');
        Console.WriteLine($"First: {parts[0]}");
        Console.WriteLine($"Last: {parts[1]}");
    }
}
