// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArray(int[,] arr, int cellWidth) // cellWidth нужна, чтобы делать одинаковую ширину у всех ячеек, для красоты таблицы
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0)
                Console.Write($"|{string.Concat(Enumerable.Repeat(" ", cellWidth - Convert.ToString(arr[i, j]).Length))} {arr[i, j]} |");
            else
                Console.Write($"{string.Concat(Enumerable.Repeat(" ", cellWidth - Convert.ToString(arr[i, j]).Length))} {arr[i, j]} |");
        }
        Console.WriteLine("");
    }
}

int[,] CreateArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

double[] ColumnAverageArray(int[,] array)
{
    double[] averageArray = new double[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            averageArray[i] += array[j, i];
        }
        averageArray[i] = Math.Round(averageArray[i] / array.GetLength(0), 2);
    }
    return averageArray;
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);

Console.WriteLine("Дан массив: ");
int[,] myArray = CreateArray(row, col, 0, 100);
PrintArray(myArray, 4);

Console.WriteLine();
Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join(" ; ", ColumnAverageArray(myArray))}.");