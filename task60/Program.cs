// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void PrintCube(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine("");
        }
    }
}

int[,,] CreateCube(int size)
{
    int[] uniqueNumbers = new int[size * size * size];
    int count = 0;
    while (count < uniqueNumbers.Length)
    {
        int temp = new Random().Next(10, 100);
        if (uniqueNumbers.Contains(temp) == false)
        {
            uniqueNumbers[count] = temp;
            count++;
        }
    }
    int l = 0;
    int[,,] cube = new int[size, size, size];
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                cube[i, j, k] = uniqueNumbers[l];
                l++;
            }
        }
    }
    return cube;
}

Console.WriteLine("Массив размером 2 x 2 x 2 из неповторяющихся двузначных чисел:");

int[,,] myCube = CreateCube(2);
PrintCube(myCube);

Console.WriteLine();