// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateDoubleArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++) array[i] = Math.Round(rand.NextDouble() * rand.Next(minValue, maxValue), 2);
    return array;
}

void PrintDoubleArray(double[] collection)
{
    foreach (var item in collection) Console.Write(item + "  ");
}

double MaxMinDiff(double[] col)
{
    double diff = 0.00;
    int minIndex = 0;
    int maxIndex = 0;
    for (int i = 0; i < col.Length; i++)
    {
        if (col[i] < col[minIndex]) minIndex = i;
        if (col[i] > col[maxIndex]) maxIndex = i;
    }
    diff = Math.Round(col[maxIndex] - col[minIndex], 2);
    return diff;
}

double[] myArray = CreateDoubleArray(5, 0, 1000);

Console.WriteLine("Дан массив вещественных чисел:");
PrintDoubleArray(myArray);

Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами равна: {MaxMinDiff(myArray)}");