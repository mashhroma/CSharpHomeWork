// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] CreateArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(minValue,maxValue);
    return array;
}

void PrintArray (int[] collection)
{
    foreach (var item in collection) Console.Write (item + " ");
}

int FindCountInRange (int[] col, int rangeStart, int rangeEnd)
{
    int count = 0;
    foreach (var item in col)
    {
        if (item > rangeStart && item < rangeEnd) count++;
    }
    return count;
}

int[] myArray = CreateArray(123, 0, 1000);
int start = 10;
int end = 99;

PrintArray(myArray);

Console.WriteLine();
Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [{start},{end}]: {FindCountInRange(myArray, start, end)}.");