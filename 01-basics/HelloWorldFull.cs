// Canonical structure: namespace, class, Main.
using System;

namespace HelloCSharp
{
    class Program
    {
        static string greeting = "Hello, World!";  // field

        static void Main(string[] args)            // entry point
        {
            PrintGreeting();                       // method call
        }

        static void PrintGreeting()                // method
        {
            Console.WriteLine(greeting);
        }
    }
}
