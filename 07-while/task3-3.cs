/*
Задача 3.3. Таблица LOD-уровней.

Условие.
Перебрать массив lodLevels.
Через switch expression по имени объекта (High, Medium, Low, иначе)
получить стоимость (100, 50, 20, 0).
Накопить суммарную стоимость и вывести для каждого объекта
имя и стоимость. После цикла вывести сумму.

Алгоритм:
1. Объявить поле GameObject[] lodLevels.
2. В Start(): int totalCost = 0.
3. foreach (GameObject level in lodLevels):
   - string name = level.name;
   - int cost = name switch { "High" => 100, "Medium" => 50, "Low" => 20, _ => 0 };
   - totalCost += cost;
   - Debug.Log(name + " -> cost " + cost);
4. После цикла: Debug.Log("Total cost: " + totalCost).
*/

using UnityEngine;

public class LodCostTable : MonoBehaviour
{
    public GameObject[] lodLevels;

    void Start()
    {
        // TODO: int totalCost = 0;
        // TODO: foreach (GameObject level in lodLevels)
        // TODO:   string name = level.name;
        // TODO:   int cost = name switch { "High" => 100, "Medium" => 50, "Low" => 20, _ => 0 };
        // TODO:   totalCost += cost;
        // TODO:   Debug.Log(name + " -> cost " + cost);
        // TODO: Debug.Log("Total cost: " + totalCost);
    }
}
