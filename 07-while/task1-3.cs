/*
Задача 1.3. Подсказка хотя бы один раз.

Условие.
Показать панель-подсказку и увеличить счётчик показов.
Повторять, пока счётчик показов меньше 1.
После цикла скрыть панель и вывести "Hint closed".

Алгоритм:
1. Объявить поле GameObject hintPanel.
2. Объявить поле int shows = 0.
3. В Start(): выполнить тело хотя бы один раз (do while):
   - shows++;
   - hintPanel.SetActive(true);
   - Debug.Log("Hint shown: " + shows).
4. Условие продолжения: shows < 1.
5. После цикла: hintPanel.SetActive(false).
6. Вывести "Hint closed".
*/

using UnityEngine;

public class HintOnce : MonoBehaviour
{
    public GameObject hintPanel;
    public int shows = 0;

    void Start()
    {
        // TODO: do { shows++; hintPanel.SetActive(true); Debug.Log("Hint shown: " + shows); }
        // TODO: while (shows < 1);
        // TODO: hintPanel.SetActive(false);
        // TODO: Debug.Log("Hint closed");
    }
}
