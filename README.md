# Итоговая проверочная работа GeekBrains

Работа для проверки знаний от [GeekBrains](https://gb.ru)

Задание:

1. Создать репозиторий на GitHub
2. Нарисовать [блок-схему алгоритма](#блок-схема)
3. Снабдить репозиторий оформленным текстовым описанием [решения](#решение)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим проектом

## Задача

> Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Блок-схема

```mermaid
%%{init: { "theme": "dark", "flowchart": { "curve": "linear" } } }%%

    graph TD
    Start:::startClass-->A[/"size<br>array[size]"/] --> B["i = 0<br>j = 0<br>step = 1<br>counter = 0"] --> C{i < size}
    C -->|Yes| D{"array[i].length < 4"}
        D -->|Yes| E[counter = counter + 1]
            E --> F[i = i + step] --> C
        D -->|No| F

    C -->|No| G["cutArray[counter]<br>i = 0"] --> H{i < size}
        H -->|Yes| I{"array[i].length <= 3"}
            I -->|Yes| J["cutArray[j] = array[i]<br>j = j + 1"]
                J --> K[i = i + step] --> H
            I -->|No| K
        H -->|No| End:::endClass

    classDef startClass fill:#470;
    classDef endClass fill:#812;
```

## Решение

В программе присутствует 2 функции:

- `string[] CutArray(string[] array, int maxLength = 3)`

основная функция для возвращения обрезанного массива

принимает на вход исходный массив и максимальную длину строки (значение по умолчанию: 3)

- `void ShowArrayString(string[] array, string msg = "Array")`

вспомогательная функция для вывода массива в консоль

принимает на вход массив и сообщение для вывода в консоль перед массивом (значение по умолчанию: Array)
