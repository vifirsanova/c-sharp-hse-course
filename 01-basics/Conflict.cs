// This file does NOT compile.
// Two classes with the same name in the global namespace.
// Expected error: CS0101.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите имя: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Привет, {name}!");
    }
}

class Program   // duplicate name
{
    public static string Exclaim(string s) => s + "!";
}
