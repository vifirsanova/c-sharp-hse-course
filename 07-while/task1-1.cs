/*
Задача 1.1. Зарядка VR-контроллера.

Условие.
Заряд контроллера растёт шагами по 25%, пока не достигнет 100%.
На каждом шаге вывести процент в консоль.
Когда заряд достиг 100% — покрасить индикатор в зелёный
и вывести "Controller ready!".

Алгоритм:
1. Объявить поле Renderer indicator (видно в Inspector).
2. Объявить поле int charge = 0.
3. В Start(): пока charge < 100 — увеличивать charge на 25
   и выводить процент в консоль.
4. После цикла покрасить indicator в Color.green.
5. Вывести "Controller ready!".
*/

using UnityEngine;

public class ControllerCharge : MonoBehaviour
{
    public Renderer indicator;
    public int charge = 0;

    void Start()
    {
        // TODO: while charge < 100 -> charge += 25; Debug.Log("Charge: " + charge + "%")
        // TODO: set indicator.material.color = Color.green
        // TODO: Debug.Log("Controller ready!")
    }
}
