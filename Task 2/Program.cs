// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт
// номер строки с наименьшей суммой элементов: 1 строка

int[] GetSumsOfElements(int[,] array)
{
    int[] sums = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int countSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            countSum = countSum + array[i, j]; 
        }
        sums[i] = countSum;
    }
    return sums;
}

int GetMinSumElements(int[] array)
{
    int min = array[0];
    int minIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (min > array[i])
        {
            min = array[i];
            minIndex = i;
        }
    }
    return minIndex + 1;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, {5, 2, 6, 7} };
PrintArray(array);
int[] sumsOfElements = GetSumsOfElements(array);
int minSumElements = GetMinSumElements(sumsOfElements);
Console.Write("Номер строки c наименьшей суммой элементов: " + minSumElements);
