/*
Задача 5 (урон). Расчёт урона по уровням
Скрипт прикреплён к объекту.
В Update программа:
1. при каждом нажатии клавиши Q увеличивает счётчик атак на 1
2. при достижении 3 атак запускает цикл for от 1 до 5
   и для каждого уровня выводит "<baseDamage> x <level> = <урон>"
3. после вывода таблицы выводит "---" и сбрасывает счётчик атак в 0
*/

using UnityEngine;

public class DamageOnThreshold : MonoBehaviour
{
    private int count = 0;
    public int baseDamage = 7;

    void Update()
    {
        // ваш код здесь
    }
}
