/*
Задача 2.3. Уровни детализации объекта (LOD).

Условие.
Есть массив из трёх объектов LOD.
По числу lod (0–2) через switch expression получить название уровня
(High detail, Medium detail, Low detail, иначе Unknown).
В цикле for по массиву включить только объект с индексом lod,
остальные выключить, и вывести для каждого название и ON/OFF.

Алгоритм:
1. Объявить поле GameObject[] lodLevels.
2. Объявить поле int lod = 2.
3. В Start(): for (int i = 0; i < lodLevels.Length; i++).
4. Внутри цикла через switch expression по i получить string title.
5. bool active = (i == lod).
6. lodLevels[i].SetActive(active).
7. Вывести title + ": " + (active ? "ON" : "OFF").
*/

using UnityEngine;

public class LodSwitcher : MonoBehaviour
{
    public GameObject[] lodLevels;
    public int lod = 2;

    void Start()
    {
        // TODO: for (int i = 0; i < lodLevels.Length; i++)
        // TODO:   string title = i switch { 0 => "High detail", 1 => "Medium detail", 2 => "Low detail", _ => "Unknown" };
        // TODO:   bool active = (i == lod);
        // TODO:   lodLevels[i].SetActive(active);
        // TODO:   Debug.Log(title + ": " + (active ? "ON" : "OFF"));
    }
}
