// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void FindMinSumRow(int[,] array)
{
    int minSumRow = 0;
    int minSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (i == 0) minSum = sum;
        if (sum < minSum)
        {
            minSum = sum;
            minSumRow = i;
        }
        Console.WriteLine($"Сумма строки с индексом {i} равна {sum}.");
    }
    Console.WriteLine("Строка с наименьшей суммой элементов: " + minSumRow);
}

Console.WriteLine("Данная программа находит строку с наименьшей суммой элементов.");
Console.WriteLine("Чтобы создать таблицу, заполненную рандомными числами, введите данные.");

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);

Console.WriteLine("Созданный массив: ");
int[,] myArray = CreateArray(row, col, -10, 10);
PrintArray(myArray, 4);

Console.WriteLine();
FindMinSumRow(myArray);

Console.WriteLine();
