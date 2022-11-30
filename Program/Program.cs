// Главная функция для возвращения обрезанного массива
string[] CutArray(string[] array, int maxLength = 3)
{
    int j = 0;

    foreach (string el in array)
        if (el.Length <= maxLength)
            j++;

    string[] cuttedArray = new string[j];
    j = 0;

    foreach (string el in array)
        if (el.Length <= maxLength)
        {
            cuttedArray[j] = el;
            j++;
        }

    return cuttedArray;
}

// Вспомогательная функция для вывода массива в консоль
void ShowArrayString(string[] array, string msg = "Array")
{
    Console.WriteLine(msg + ":");

    foreach (string el in array)
        Console.Write(el + " ");

    Console.WriteLine();
}


string[] firstArray = new string[] { "-2", "2", "world", ":-)" };

ShowArrayString(firstArray);
string[] resultArray = CutArray(firstArray);
ShowArrayString(resultArray, "Cutted array");