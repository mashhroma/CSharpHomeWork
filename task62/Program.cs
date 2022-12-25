// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintArray(int[,] arr, int cellWidth) // cellWidth нужна, чтобы делать одинаковую ширину у всех ячеек, для красоты таблицы
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < 10)
                Console.Write($" 0{arr[i, j]} ");
            else
                Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine("");
    }
}

int[,] SpiralFillArray(int size)
{
    int[,] spiralArray = new int[size, size];
    int i = 0;
    int j = 0;
    int n = 1;
    while (n <= size * size)
    {
        if (spiralArray[i, j] == 0) spiralArray[i, j] = n;
        else
        {
            if (j < size - 1 && i == 0) j++;
            else if (i < size - 1 && j == size - 1) i++;
            else if (j > 0 && i == size - 1) j--;
            else if (i > 1 && j == 0) i--;
            else if (spiralArray[i, j + 1] == 0) j++;
            else if (spiralArray[i + 1, j] == 0) i++;
            else if (spiralArray[i, j - 1] == 0) j--;
            else if (spiralArray[i - 1, j] == 0) i--;
            n++;
        }
    }
    return spiralArray;
}

Console.WriteLine();

int[,] myArray = SpiralFillArray(4);
PrintArray(myArray, 2);

Console.WriteLine();