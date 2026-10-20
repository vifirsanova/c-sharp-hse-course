/*
Задача 3.2. Подсветить только "золотые" монеты.

Условие.
Перебрать массив coins.
Для каждой монеты получить компонент CoinData.
Если он есть и value >= goldValue — покрасить монету в жёлтый,
увеличить счётчик золотых и вывести имя и стоимость в консоль.
После цикла вывести общее число золотых монет.

Алгоритм:
1. Объявить поле GameObject[] coins.
2. Объявить поле int goldValue = 5.
3. В Start(): int goldCount = 0.
4. foreach (GameObject coin in coins):
   - CoinData data = coin.GetComponent<CoinData>();
   - если data != null && data.value >= goldValue:
     * coin.GetComponent<Renderer>().material.color = Color.yellow;
     * goldCount++;
     * Debug.Log("Gold coin: " + coin.name + " (" + data.value + ")");
5. После цикла: Debug.Log("Total gold coins: " + goldCount).
*/

using UnityEngine;

public class GoldCoinHighlighter : MonoBehaviour
{
    public GameObject[] coins;
    public int goldValue = 5;

    void Start()
    {
        // TODO: int goldCount = 0;
        // TODO: foreach (GameObject coin in coins)
        // TODO:   CoinData data = coin.GetComponent<CoinData>();
        // TODO:   if (data != null && data.value >= goldValue) { ... }
        // TODO: Debug.Log("Total gold coins: " + goldCount);
    }

    // TODO: separate CoinData class with public int value;
}
