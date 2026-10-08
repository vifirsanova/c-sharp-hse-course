/*
Задача 1. Чётное или нечётное
Пользователь вводит целое число.
Программа:
1. принимает число через Console.ReadLine()
2. определяет, чётное оно или нечётное
3. выводит "<число> is even" или "<число> is odd"
4. дополнительно проверяет: если число равно 0 — вывести "zero"
*/

using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter a number: ");
    int number = int.Parse(Console.ReadLine());
    // ваш код здесь
  }
}
