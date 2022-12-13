// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(minValue,maxValue+1);
    return array;
}

void PrintArray (int[] collection)
{
    foreach (var item in collection) Console.Write (item + " ");
}

int OddPosSum (int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i%2 != 0) sum += arr[i];
    }
    return sum;
}

int[] myArray = CreateArray(10, -100, 100);

PrintArray(myArray);

Console.WriteLine();
Console.WriteLine($"Сумма элементов с нечетным индексом равна: {OddPosSum(myArray)}.");
