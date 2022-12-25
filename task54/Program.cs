// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] SortRowsInDescending (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if (array[i,j] > array[i,k])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temp;
                }
            }
        }
    }
    return array;
}

Console.WriteLine("Данная программа упорядочит по убыванию элементы каждой строки двумерного массива.");
Console.WriteLine("Чтобы создать таблицу, заполненную рандомными числами, введите данные.");

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);

Console.WriteLine("Созданный массив: ");
int[,] myArray = CreateArray(row, col, -100, 100);
PrintArray(myArray, 4);

Console.WriteLine();
Console.WriteLine("Массив после сортировки по убыванию элементов каждой строки: ");
PrintArray(SortRowsInDescending(myArray), 4);
Console.WriteLine();