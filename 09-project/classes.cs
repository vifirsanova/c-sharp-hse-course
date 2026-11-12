// ============================================================
// Seminar 10. Классы, коллекции, исключения + подготовка к проекту.
// Заготовки задач. Решений нет.
// Положить в Assets/Scripts/Seminar10/
// ============================================================
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace Classes
{
    // ЗАДАЧА 1. Инвентарь монет.
    // Тема: класс + List<T> + foreach.
    // Условие: класс Coin (value, name); List<Coin> — 3 монеты,
    // вывод описания через foreach и суммарной стоимости.
    public class Coin
    {
        // TODO: поля value, name, конструктор, Describe()
    }

    public class Task1_Inventory : MonoBehaviour
    {
        List<Coin> inventory = new List<Coin>();

        void Start()
        {
            // TODO: добавить 3 монеты, foreach, сумма
        }
    }

    // ЗАДАЧА 2. Словарь очков.
    // Тема: Dictionary<string,int> + foreach + ContainsKey.
    // Условие: 3 игрока, обновить счёт одного, вывести всех;
    // отсутствующий — "Not found".
    public class Task2_Scores : MonoBehaviour
    {
        Dictionary<string, int> scores = new Dictionary<string, int>();

        void Start()
        {
            // TODO
        }
    }

    // ЗАДАЧА 3. Безопасная загрузка сцены.
    // Тема: try/catch + SceneManager.
    // Условие: bool TryLoadScene(string name): try LoadScene,
    // catch — LogError + false, иначе true.
    public class Task3_SafeScene : MonoBehaviour
    {
        bool TryLoadScene(string name)
        {
            // TODO
            return false;
        }
    }
}
