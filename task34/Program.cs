// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int CountEvenNums (int[] collection)
{
    int count = 0;
    foreach (var item in collection)
    {
        if (item%2 == 0) count++;
    }
    return count;
}

int[] myArray = CreateArray(10, 100, 1000);

PrintArray(myArray);

Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве: {CountEvenNums(myArray)}.");