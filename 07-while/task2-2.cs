/*
Задача 2.2. Классификация расстояния в AR.

Условие.
Посчитать расстояние между user и target через Vector3.Distance.
Через switch expression с диапазонами получить зону:
< 1  -> "too close",
< 3  -> "near",
< 10 -> "mid",
иначе -> "far".
Вывести расстояние и зону.
Если зона "too close" — вывести предупреждение.

Алгоритм:
1. Объявить поля Transform user, Transform target.
2. В Start(): float distance = Vector3.Distance(user.position, target.position).
3. Через switch expression с диапазонами получить string zone.
4. Вывести "Distance: " + distance + ", zone: " + zone.
5. Если zone == "too close" — Debug.Log("Warning: object is too close!").
*/

using UnityEngine;

public class DistanceZone : MonoBehaviour
{
    public Transform user;
    public Transform target;

    void Start()
    {
        // TODO: float distance = Vector3.Distance(user.position, target.position);
        // TODO: string zone = distance switch { < 1f => "too close", < 3f => "near", < 10f => "mid", _ => "far" };
        // TODO: Debug.Log("Distance: " + distance + ", zone: " + zone);
        // TODO: if (zone == "too close") Debug.Log("Warning: object is too close!");
    }
}
