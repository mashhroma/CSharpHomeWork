// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixProduct(int[,] array1, int[,] array2)
{
    int[,] product = new int[array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            int productColRow = 0;
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                productColRow = array1[i, k] * array2[k, j];
                product[i, j] += productColRow;
            }
        }
    }
    return product;
}

Console.WriteLine("Данная программа находит произведение двух матриц.");

Console.WriteLine("Первая матрица: ");
int[,] matrix1 = CreateArray(2, 2, 0, 10);
PrintArray(matrix1, 4);

Console.WriteLine("Вторая матрица: ");
int[,] matrix2 = CreateArray(2, 2, 0, 10);
PrintArray(matrix2, 4);

Console.WriteLine();

if (matrix1.GetLength(0) == matrix2.GetLength(1) && matrix1.GetLength(1) == matrix2.GetLength(0))
{
    Console.WriteLine("Произведение матриц: ");
    int[,] matrix3 = MatrixProduct(matrix1, matrix2);
    PrintArray(matrix3, 4);
}
else Console.WriteLine($"Перемножить данные матрицы невозможно.");