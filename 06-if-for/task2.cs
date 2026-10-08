/*
Задача 2. Максимум из трёх
Пользователь вводит три числа.
Программа:
1. принимает три числа через Console.ReadLine()
2. определяет наибольшее из них
3. выводит "Max: <наибольшее>"
4. если все три числа равны — вывести "All equal"
*/

using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter first number: ");
    int a = int.Parse(Console.ReadLine());

    Console.Write("Enter second number: ");
    int b = int.Parse(Console.ReadLine());

    Console.Write("Enter third number: ");
    int c = int.Parse(Console.ReadLine());
    // ваш код здесь
  }
}
