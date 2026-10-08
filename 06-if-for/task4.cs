/*
Задача 4 (инвентарь). Накопление предметов и подсчёт стоимости
Скрипт прикреплён к объекту.
В Update программа:
1. при каждом нажатии Space добавляет в инвентарь 1 монету
2. при достижении 5 монет запускает цикл for от 1 до count
   и считает суммарную стоимость всех монет (каждая монета стоит 10)
3. выводит "Coins: <count>, total value: <сумма>"
4. после вывода очищает инвентарь (count = 0)
*/

using UnityEngine;

public class InventoryValue : MonoBehaviour
{
    private int count = 0;
    private int coinValue = 10;

    void Update()
    {
        // ваш код здесь
    }
}
