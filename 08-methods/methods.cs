using UnityEngine;

namespace Methods
{
    // ------------------------------------------------------------
    // ЗАДАЧА 1. Приветствие для AR-маркера
    // Тема: определение и вызов метода.
    //
    // Зачем в проекте: при старте AR-сцены один раз вывести подсказку.
    //
    // Условие:
    // - Написать метод ShowHint(), который выводит
    //   "Point the camera at the marker".
    // - Вызвать его дважды из Start().
    // - В Update() вызывать ShowHint() при нажатии клавиши R
    //   (Input.GetKeyDown(KeyCode.R)).
    //
    // Unity: скрипт повесить на Main Camera, сцена пустая.
    // ------------------------------------------------------------
    public class Task1_ShowHint : MonoBehaviour
    {
        void Start()
        {
            // TODO: вызвать ShowHint() дважды
        }

        void Update()
        {
            // TODO: если Input.GetKeyDown(KeyCode.R) — вызвать ShowHint()
        }

        // TODO: объявить метод ShowHint()
    }

    // ------------------------------------------------------------
    // ЗАДАЧА 2. Процент заряда контроллера
    // Тема: параметры + возврат значения.
    //
    // Зачем в проекте: индикатор заряда VR-контроллера.
    //
    // Условие:
    // - Метод Color GetChargeColor(int percent) возвращает:
    //     < 50  -> Color.red
    //     < 100 -> Color.yellow
    //     == 100 -> Color.green
    // - В Start() вызвать для percent = 75, покрасить indicator,
    //   вывести процент в консоль.
    //
    // Unity: куб-индикатор, перетащить MeshRenderer в поле indicator.
    // ------------------------------------------------------------
    public class Task2_ChargeColor : MonoBehaviour
    {
        public Renderer indicator;

        void Start()
        {
            // TODO: получить цвет через GetChargeColor(75),
            //       применить к indicator.material.color,
            //       вывести процент в консоль
        }

        // TODO: объявить метод Color GetChargeColor(int percent)
    }

    // ------------------------------------------------------------
    // ЗАДАЧА 3. Расстояние до AR-объекта
    // Тема: параметры-объекты + возврат float.
    //
    // Зачем в проекте: AR-объект не должен подходить слишком близко.
    //
    // Условие:
    // - Метод float GetDistance(Transform a, Transform b) возвращает
    //   Vector3.Distance(a.position, b.position).
    // - В Start() посчитать расстояние между user и target, вывести.
    // - Если расстояние < 1 — вывести "Too close!".
    //
    // Unity: два куба user и target, перетащить Transform в поля.
    // ------------------------------------------------------------
    public class Task3_Distance : MonoBehaviour
    {
        public Transform user;
        public Transform target;

        void Start()
        {
            // TODO: посчитать расстояние, вывести,
            //       при < 1 вывести "Too close!"
        }

        // TODO: объявить метод float GetDistance(Transform a, Transform b)
    }

    // ------------------------------------------------------------
    // ЗАДАЧА 4. Счётчик золотых монет (out)
    // Тема: out-параметр + возврат bool.
    //
    // Зачем в проекте: посчитать золотые монеты и сообщить,
    // нашлись ли они вообще.
    //
    // Условие:
    // - Метод bool TryCountGold(GameObject[] coins, int goldValue,
    //   out int count) считает монеты с CoinData.value >= goldValue
    //   и возвращает true, если такие есть (count > 0).
    // - В Start() вызвать метод: если true — вывести количество,
    //   иначе "No gold coins".
    //
    // Unity: скрипт CoinData с public int value; повесить на кубы,
    //        задать значения в Inspector, перетащить кубы в coins.
    // ------------------------------------------------------------
    public class Task4_TryCountGold : MonoBehaviour
    {
        public GameObject[] coins;
        public int goldValue = 5;

        void Start()
        {
            // TODO: вызвать TryCountGold, обработать результат
        }

        // TODO: объявить метод
        // bool TryCountGold(GameObject[] coins, int goldValue, out int count)
    }

    // Вспомогательный компонент для задачи 4 (повесить на монеты).
    public class CoinData : MonoBehaviour
    {
        public int value = 1;
    }

    // ------------------------------------------------------------
    // ЗАДАЧА 5. Суммарная стоимость LOD (params)
    // Тема: params + возврат int.
    //
    // Зачем в проекте: посчитать суммарную стоимость LOD-уровней
    // для отладки производительности.
    //
    // Условие:
    // - Метод int SumCost(params int[] costs) возвращает сумму.
    // - В Start() вызвать SumCost(100, 50, 20), вывести результат.
    // - Затем вызвать SumCost(lodCosts) — массив из Inspector.
    //
    // Unity: массив lodCosts задать в Inspector.
    // ------------------------------------------------------------
    public class Task5_SumCost : MonoBehaviour
    {
        public int[] lodCosts = { 100, 50, 20 };

        void Start()
        {
            // TODO: два вызова SumCost и вывод
        }

        // TODO: объявить метод int SumCost(params int[] costs)
    }

    // ------------------------------------------------------------
    // ЗАДАЧА 6. Подсветка маркеров (перегрузка)
    // Тема: перегрузка методов + foreach.
    //
    // Зачем в проекте: подсветить найденные AR-маркеры,
    // для одного — особым цветом.
    //
    // Условие:
    // - void Highlight(GameObject obj) — красит в зелёный.
    // - void Highlight(GameObject obj, Color color) — красит в color.
    // - В Start() пройти foreach по markers и вызвать первый метод
    //   для всех, второй — для markers[0] с Color.yellow
    //   (проверить, что массив не пуст).
    //
    // Unity: 3-4 куба-маркера в массив markers.
    // ------------------------------------------------------------
    public class Task6_Highlight : MonoBehaviour
    {
        public GameObject[] markers;

        void Start()
        {
            // TODO: foreach по markers -> Highlight(obj)
            //       Highlight(markers[0], Color.yellow)
        }

        // TODO: объявить перегрузки Highlight
    }
}
