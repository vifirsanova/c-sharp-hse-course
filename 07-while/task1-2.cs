/*
Задача 1.2. Индикатор заряда цветом.

Условие.
Заряд растёт шагами по 25%, пока не достигнет 100%.
Цвет индикатора: меньше 50% — красный, меньше 100% — жёлтый,
100% — зелёный. На каждом шаге вывести процент в консоль.

Алгоритм:
1. Объявить поле Renderer indicator.
2. Объявить поле int charge = 0.
3. В Start(): пока charge < 100 — увеличивать charge на 25.
4. Внутри цикла через if / else if / else выбрать цвет:
   charge < 50 -> Color.red;
   charge < 100 -> Color.yellow;
   иначе -> Color.green.
5. Присвоить выбранный цвет indicator.material.color.
6. Вывести процент в консоль.
*/

using UnityEngine;

public class ChargeColor : MonoBehaviour
{
    public Renderer indicator;
    public int charge = 0;

    void Start()
    {
        // TODO: while charge < 100 -> charge += 25
        // TODO: pick color with if / else if / else
        // TODO: apply color to indicator.material.color
        // TODO: Debug.Log("Charge: " + charge + "%")
    }
}
