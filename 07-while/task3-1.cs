/*
Задача 3.1. Подсветить все AR-маркеры.

Условие.
Перебрать массив markers.
Для каждого объекта получить Renderer.
Если компонент есть — покрасить объект в зелёный.
Если нет — вывести в консоль "<name> has no Renderer".

Алгоритм:
1. Объявить поле GameObject[] markers.
2. В Start(): foreach (GameObject marker in markers).
3. Renderer r = marker.GetComponent<Renderer>().
4. Если r != null — r.material.color = Color.green.
5. Иначе — Debug.Log(marker.name + " has no Renderer").
*/

using UnityEngine;

public class MarkerHighlighter : MonoBehaviour
{
    public GameObject[] markers;

    void Start()
    {
        // TODO: foreach (GameObject marker in markers)
        // TODO:   Renderer r = marker.GetComponent<Renderer>();
        // TODO:   if (r != null) r.material.color = Color.green;
        // TODO:   else Debug.Log(marker.name + " has no Renderer");
    }
}
