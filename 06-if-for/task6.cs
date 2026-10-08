/*
Задача 6 (золото). Покупка и серия улучшений
Скрипт прикреплён к объекту.
В Update программа:
1. при каждом нажатии клавиши R увеличивает счётчик улучшений на 1
2. при достижении 5 улучшений запускает цикл for от 5 до 1
   и для каждого уровня выводит "<level>... -<cost> gold"
3. после цикла выводит "Upgrade complete!"
4. сбрасывает счётчик в 0
*/

using UnityEngine;

public class UpgradePurchase : MonoBehaviour
{
    private int count = 0;
    public int gold = 500;
    public int costPerLevel = 20;

    void Update()
    {
        // ваш код здесь
    }
}
