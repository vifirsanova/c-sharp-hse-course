using UnityEngine;

namespace Prefab
{
    // ------------------------------------------------------------
    // ЗАДАЧА 1. Спавн AR-маркеров в цикле
    // Тема: префаб + Instantiate + for.
    //
    // Зачем в проекте: при старте AR-сцены расставить маркеры в ряд.
    //
    // Условие:
    // - Создать префаб Marker.prefab (куб), перетащить в markerPrefab.
    // - В Start() через for создать 5 экземпляров
    //   в точках (i * 2, 0, 0).
    // - Для каждого созданного вывести его имя в консоль.
    // ------------------------------------------------------------
    public class Task1_SpawnMarkers : MonoBehaviour
    {
        public GameObject markerPrefab;

        void Start()
        {
            // TODO: for по 5 итерациям,
            //       Instantiate(markerPrefab, new Vector3(i * 2, 0, 0), Quaternion.identity),
            //       Debug.Log(имя созданного)
        }
    }

    // ------------------------------------------------------------
    // ЗАДАЧА 2. Случайные позиции для спавна
    // Тема: Instantiate + Random.Range.
    //
    // Зачем в проекте: расставить AR-объекты случайно по площади.
    //
    // Условие:
    // - Создать 10 экземпляров coinPrefab.
    // - Позиция: x и z от -5 до 5, y = 1.
    // - Вывести количество созданных.
    // ------------------------------------------------------------
    public class Task2_SpawnRandom : MonoBehaviour
    {
        public GameObject coinPrefab;
        int count = 10;

        void Start()
        {
            // TODO: цикл на count, Instantiate со случайной позицией,
            //       вывод количества
        }
    }

    // ------------------------------------------------------------
    // ЗАДАЧА 3. Падающие монеты
    // Тема: Rigidbody (Use Gravity) + Instantiate.
    //
    // Зачем в проекте: монеты падают сверху — нужна физика.
    //
    // Условие:
    // - На префабе coinPrefab включить Rigidbody (Use Gravity = true).
    // - В Start() создать 5 экземпляров на высоте y = 5.
    // - Убедиться, что монеты падают на Plane.
    // ------------------------------------------------------------
    public class Task3_FallingCoins : MonoBehaviour
    {
        public GameObject coinPrefab;

        void Start()
        {
            // TODO: цикл на 5, Instantiate(prefab, new Vector3(..., 5, ...), Quaternion.identity)
        }
    }

    // ------------------------------------------------------------
    // ЗАДАЧА 4. Подброс шара силой
    // Тема: Rigidbody.AddForce + GetComponent + FixedUpdate.
    //
    // Зачем в проекте: пользователь <<подбрасывает>> объект — импульс силы.
    //
    // Условие:
    // - Шар с Rigidbody на сцене.
    // - В Start() получить Rigidbody и применить
    //   AddForce(Vector3.up * 8f, ForceMode.Impulse).
    // - В FixedUpdate() если y < -2 — вывести "Ball fell".
    // ------------------------------------------------------------
    public class Task4_BallForce : MonoBehaviour
    {
        Rigidbody rb;

        void Start()
        {
            // TODO: rb = GetComponent<Rigidbody>();
            //       rb.AddForce(...)
        }

        void FixedUpdate()
        {
            // TODO: проверка y < -2
        }
    }

    // ------------------------------------------------------------
    // ЗАДАЧА 5. Удаление упавших монет
    // Тема: Destroy + FixedUpdate. Скрипт на префабе.
    //
    // Зачем в проекте: упавшие за пределы сцены монеты надо удалять.
    //
    // Условие:
    // - Скрипт повесить на префаб coinPrefab (Apply после правок).
    // - В FixedUpdate() если transform.position.y < -2 —
    //   вывести имя и Destroy(gameObject).
    // ------------------------------------------------------------
    public class Task5_CoinFall : MonoBehaviour
    {
        void FixedUpdate()
        {
            // TODO: проверка y < -2 и Destroy
        }
    }

    // ------------------------------------------------------------
    // ЗАДАЧА 6. Спавн + падение + удаление (всё вместе)
    // Тема: комбинация Instantiate, Rigidbody, Destroy.
    //
    // Зачем в проекте: мини-прототип AR-игры — монеты падают,
    // упавшие удаляются.
    //
    // Условие:
    // - В Start() создать 8 экземпляров coinPrefab:
    //   y = 6, x/z случайные от -4 до 4.
    // - На префабе — Rigidbody и Task5_CoinFall.
    // - В Update() вывести количество объектов на сцене раз в секунду
    //   (через счётчик кадров).
    // ------------------------------------------------------------
    public class Task6_SpawnFallDestroy : MonoBehaviour
    {
        public GameObject coinPrefab;
        int spawnedCount = 8;

        void Start()
        {
            // TODO: цикл на spawnedCount, Instantiate
        }

        void Update()
        {
            // TODO: раз в секунду вывести FindObjectsOfType<...>().Length
            //       или счётчик кадров
        }
    }
}
