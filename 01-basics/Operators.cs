// Operators and expressions.
using System;

class Program
{
    static void Main()
    {
        string s = "Hello";
        string withBang = s + "!";                // + : string concatenation
        string greeting = $"Hi, {s}";             // $ : interpolation
        string line = Console.ReadLine();         // expression with result

        Console.WriteLine(withBang);
        Console.WriteLine(greeting);
        Console.WriteLine(line);
    }
}
