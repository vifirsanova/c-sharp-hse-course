/*
Задача 2.1. Состояние VR-контроллера.

Условие.
По числу mode (0–3) получить строковое имя состояния
(Idle, Tracking, Menu, Paused, иначе Unknown)
и цвет индикатора через switch expression.
Покрасить индикатор и вывести имя в консоль.

Алгоритм:
1. Объявить поле Renderer indicator.
2. Объявить поле int mode = 2.
3. В Start(): через switch expression получить string name по mode.
4. Через второй switch expression получить Color color по mode.
5. Присвоить color в indicator.material.color.
6. Вывести "Mode: " + name.
*/

using UnityEngine;

public class ControllerState : MonoBehaviour
{
    public Renderer indicator;
    public int mode = 2;

    void Start()
    {
        // TODO: string name = mode switch { 0 => "Idle", ... _ => "Unknown" };
        // TODO: Color color = mode switch { 0 => Color.gray, ... _ => Color.red };
        // TODO: indicator.material.color = color;
        // TODO: Debug.Log("Mode: " + name);
    }
}
