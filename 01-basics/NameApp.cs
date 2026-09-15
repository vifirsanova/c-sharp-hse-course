using System;
using HelloCSharp.Tools;          // <-- это отличие

namespace HelloCSharp.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine(Formatter.Exclaim($"Привет, {name}"));
        }
    }
}

namespace HelloCSharp.Tools       // <-- второй namespace
{
    class Formatter
    {
        public static string Exclaim(string s) => s + "!";
    }
}
