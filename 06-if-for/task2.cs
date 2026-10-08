/*
Задача 2. Переключатель цвета по чётности
Скрипт прикреплён к объекту с Renderer.
В Update программа:
1. при каждом нажатии клавиши E увеличивает счётчик на 1
2. если счётчик чётный — красит объект в красный
3. если нечётный — красит объект в синий
4. выводит "Count: <значение>, color: <red/blue>"
*/

using UnityEngine;

public class ColorByParity : MonoBehaviour
{
    private int count = 0;

    void Update()
    {
        // ваш код здесь
        // подсказка: GetComponent<Renderer>().material.color = Color.red;
    }
}
