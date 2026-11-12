using UnityEngine;

namespace Project
{
    // ЗАДАЧА 1. Найти 3 ошибки в <<коде ИИ>>.
    // Тема: отладка + чек-лист.
    // Условие: в Start() спавн каждый кадр (через Update),
    // AddForce в Update, GetComponent без null-проверки,
    // конкатенация строк в Update.
    // Задание: переписать корректно (FixedUpdate, Destroy, null-check).
    public class Task1_FixAICode : MonoBehaviour
    {
        public GameObject prefab;

        void Update()
        {
            // TODO: заменить на корректную логику
            var obj = Instantiate(prefab);
            obj.GetComponent<Rigidbody>().AddForce(Vector3.up);
            Debug.Log("spawned " + obj.name);
        }
    }

    // ЗАДАЧА 2. Визуализация зоны триггера.
    // Тема: OnDrawGizmos.
    // Условие: нарисовать красную сферу радиусом 2 вокруг объекта,
    // чтобы видеть зону до запуска.
    public class Task2_Gizmo : MonoBehaviour
    {
        void OnDrawGizmos()
        {
            // TODO: Gizmos.color = Color.red;
            //       Gizmos.DrawWireSphere(transform.position, 2f);
        }
    }

    // ЗАДАЧА 3. Безопасное получение компонента.
    // Тема: null-check + отладка.
    // Условие: метод T GetSafeComponent<T>(GameObject obj) —
    // возвращает компонент или null с LogWarning.
    public class Task3_SafeGet : MonoBehaviour
    {
        T GetSafeComponent<T>(GameObject obj) where T : Component
        {
            // TODO
            return null;
        }
    }

    // ЗАДАЧА 4. Отписка от события.
    // Тема: event + OnDestroy.
    // Условие: подписаться в Start на GameManager.OnScoreChanged,
    // отписаться в OnDestroy.
    public class Task4_EventLifecycle : MonoBehaviour
    {
        void Start()
        {
            // TODO: подписка
        }

        void OnDestroy()
        {
            // TODO: отписка
        }

        void OnScoreChanged(int score)
        {
            // TODO: обработчик
        }
    }
}
