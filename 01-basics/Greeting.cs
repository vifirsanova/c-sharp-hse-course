using System;

namespace HelloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}!");
        }
    }
}
