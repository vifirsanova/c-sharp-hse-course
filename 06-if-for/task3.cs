/*
Задача 3. Оценка по баллам
Пользователь вводит количество баллов (0–100).
Программа:
1. принимает число через Console.ReadLine()
2. выводит оценку по шкале:
   - 90–100 → "A"
   - 75–89  → "B"
   - 60–74  → "C"
   - 40–59  → "D"
   - 0–39   → "F"
3. если число меньше 0 или больше 100 — вывести "Invalid score"
*/

using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter score (0-100): ");
    int score = int.Parse(Console.ReadLine());
    // ваш код здесь
  }
}
