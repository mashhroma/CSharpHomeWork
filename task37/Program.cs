// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] PairProductArray (int[] arr)
{
    int[] pairArray = new int[arr.Length/2 + arr.Length%2];
    int n = arr.Length-1;
    for (int i = 0; i < pairArray.Length; i++)
    {
        if (i == n) pairArray[i] = arr[i];
        else pairArray[i] = arr[i]*arr[n];
        n--;
    }
    return pairArray;
}

int[] myArray = CreateArray(5, 1,10);
int[] myPairProdArray = PairProductArray(myArray);

Console.Write("Дан массив: ");
PrintArray(myArray);

Console.WriteLine();
Console.Write("Новый массив из произведений пар: ");
PrintArray(myPairProdArray);