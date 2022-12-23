// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

void PrintPascalArray(int[,] array, int cellWidth)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == 0)
                Console.Write(string.Concat(Enumerable.Repeat(" ", cellWidth - Convert.ToString(array[i, j]).Length)));
            else
                Console.Write(string.Concat(Enumerable.Repeat(" ", cellWidth - Convert.ToString(array[i, j]).Length)) + array[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] CreatePaskalArray(int rows)
{
    int[,] array = new int[rows, rows * 2 + 1];
    array[0, rows + 1] = 1;
    for (int i = 1; i < array.GetLength(0); i++) // i - строка
    {
        for (int j = 0; j < array.GetLength(1); j++) // j - столбец
        {
            if (j == 0) array[i, j] = array[i - 1, j + 1];
            else if (j == array.GetLength(1) - 1) array[i, j] = array[i - 1, j - 1];
            else array[i, j] = array[i - 1, j - 1] + array[i - 1, j + 1];
        }
    }
    return array;
}

int[,] myArray = CreatePaskalArray(15);
PrintPascalArray(myArray, 4);
Console.WriteLine();