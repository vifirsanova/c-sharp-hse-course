## Типы данных

| Категория | Где хранится | Примеры |
|---|---|---|
| Значимые (value) | Стек | `int`, `float`, `double`, `decimal`, `bool`, `char`, `byte`, `short`, `long` |
| Ссылочные (reference) | Куча (heap) | `string`, массивы (`int[]`), классы, интерфейсы, `object` |

## Основные типы

| Тип | Пример | Примечание |
|---|---|---|
| `int` | `int lives = 3;` | целые числа |
| `float` | `float speed = 5.5f;` | суффикс `f` обязателен |
| `double` | `double x = 5.5;` | 8 байт, точнее float |
| `decimal` | `decimal price = 9.99m;` | суффикс `m` |
| `bool` | `bool isActive = true;` | true / false |
| `char` | `char grade = 'A';` | один символ, одинарные кавычки |
| `string` | `string name = "Cube";` | ссылочный, двойные кавычки |
| `DateTime` | `DateTime.Now` | текущая дата и время |

## var (неявная типизация)

| Правило | Пример |
|---|---|
| Тип определяется компилятором | `var number = 42; // int` |
| Только с инициализацией | `var x;` ❌ |
| Когда тип очевиден | `var name = "Unity"; // string` |

## Преобразование типов

| Вид | Пример | Потеря данных |
|---|---|---|
| Неявное | `int a = 10; double b = a;` | нет |
| Явное | `double c = 9.99; int d = (int)c;` | да (дробная часть отбрасывается) |

> `(int)9.99` → `9` (не округление!)

## Рекомендуемые типы для задач

| Задача | Тип |
|---|---|
| Координаты X, Y, Z | `float` / `double` |
| Имя объекта | `string` |
| Длительность анимации | `float` |
| Время создания файла | `DateTime` |
| Количество полигонов | `int` |
| Флаг активности | `bool` |
| Угол поворота | `float` |

## Шаблон программы

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        // переменные
        Console.WriteLine($"Text: {var}");
    }
}
```

## Правила именования

- Осмысленные имена
- camelCase: `modelName`, `isVisible`
- Суффикс `f` для float, `m` для decimal
