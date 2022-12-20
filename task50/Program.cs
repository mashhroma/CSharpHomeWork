// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция по индексам, 1- строка и 7 -столбец)

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

void SearchPosValue(int[,] table, int rowNumber, int colNumber)
{
    if (rowNumber - 1 >= table.GetLength(0)
    || rowNumber - 1 >= table.GetLength(1)
    || colNumber - 1 >= table.GetLength(0)
    || colNumber - 1 >= table.GetLength(1))
        Console.WriteLine($"В массиве нет ячейки с адресом ([{rowNumber},{colNumber}], где {rowNumber} - строка и {colNumber} - столбец).");
    else
        Console.WriteLine($"В массиве элемент с позицией [{rowNumber},{colNumber}] имеет значение: {table[rowNumber - 1, colNumber - 1]}.");
}

Console.WriteLine("Дан массив: ");
int[,] myArray = CreateArray(10, 10, 0, 1000);
PrintArray(myArray, 4);

Console.WriteLine();

Console.WriteLine("Напишите позицию элемента в двумерном массиве, чтобы узнать его значение.");

Console.Write("Номер строки: ");
int row = int.Parse(Console.ReadLine()!);

Console.Write("Номер столбца: ");
int col = int.Parse(Console.ReadLine()!);

Console.WriteLine();
SearchPosValue(myArray, row, col);