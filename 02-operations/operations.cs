using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 3;

        Console.WriteLine($"Сумма: {a + b}");
        Console.WriteLine($"Разность: {a - b}");
        Console.WriteLine($"Произведение: {a * b}");
        Console.WriteLine($"Частное: {a / b}");
        Console.WriteLine($"Остаток: {a % b}");

        double c = 10.0;
        double d = 3.0;
        Console.WriteLine($"Деление double: {c / d}");
    }
}
