// ============================================================
// Seminar 9. Коллизии, триггеры, слои, GameManager, события, корутины.
// Заготовки задач. Решений нет.
// Положить в Assets/Scripts/Seminar9/
// ============================================================
using UnityEngine;

namespace Objects
{
    // ЗАДАЧА 1. Зона финиша.
    // Тема: OnTriggerEnter + тег.
    // Условие: куб с BoxCollider, Is Trigger = true, тег Finish.
    // В OnTriggerEnter проверить тег, вывести "Level complete!",
    // удалить шар.
    public class Task1_FinishZone : MonoBehaviour
    {
        void OnTriggerEnter(Collider other)
        {
            // TODO: проверка тега, вывод, Destroy(other.gameObject)
        }
    }

    // ЗАДАЧА 2. Ловушка обнуляет прогресс.
    // Тема: OnTriggerEnter + Destroy.
    // Условие: шарик с тегом Player; зона-ловушка с триггером.
    // Если тег Player — вывести "Trap!" и удалить игрока.
    public class Task2_Trap : MonoBehaviour
    {
        void OnTriggerEnter(Collider other)
        {
            // TODO: проверка тега Player и Destroy
        }
    }

    // ЗАДАЧА 3. Счёт через событие.
    // Тема: GameManager + event Action + триггер.
    // Условие: GameManager с событием OnScoreChanged; бонус-триггер
    // вызывает AddScore(1) и удаляет себя; HUD подписывается на событие.
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;
        public event System.Action<int> OnScoreChanged;
        int score = 0;

        void Awake()
        {
            // TODO: Instance = this;
        }

        public void AddScore(int v)
        {
            // TODO: score += v; OnScoreChanged?.Invoke(score);
        }
    }

    public class Task3_BonusTrigger : MonoBehaviour
    {
        void OnTriggerEnter(Collider other)
        {
            // TODO: вызвать GameManager.Instance.AddScore(1) и Destroy(gameObject)
        }
    }

    public class Task3_HUD : MonoBehaviour
    {
        void Start()
        {
            // TODO: подписаться GameManager.Instance.OnScoreChanged += ...
        }

        void OnDestroy()
        {
            // TODO: отписаться
        }

        // TODO: метод обновления текста/лога
    }

    // ЗАДАЧА 4. Волны бонусов.
    // Тема: корутины + Instantiate + WaitForSeconds.
    // Условие: SpawnWave() в бесконечном цикле создаёт бонус
    // в случайной точке и ждёт 2 сек. Вторая корутина останавливает
    // через 10 сек.
    public class Task4_Spawner : MonoBehaviour
    {
        public GameObject bonusPrefab;

        void Start()
        {
            // TODO: StartCoroutine(SpawnWave()); StartCoroutine(StopAfter());
        }

        System.Collections.IEnumerator SpawnWave()
        {
            // TODO: while(true) { Instantiate...; yield return new WaitForSeconds(2f); }
            yield break;
        }

        System.Collections.IEnumerator StopAfter()
        {
            // TODO: yield return new WaitForSeconds(10f); StopCoroutine...
            yield break;
        }
    }
}
