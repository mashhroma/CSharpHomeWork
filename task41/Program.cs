// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateArray(int size)
{
    int[] addArray = new int[size];
    int number = 0;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите число {i + 1} из {size}: ");
        number = int.Parse(Console.ReadLine()!);
        addArray[i] = number;
    }
    return addArray;
}

int PositiveCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

Console.Write("Напишите, сколько чисел вы хотите ввести: ");
int m = int.Parse(Console.ReadLine()!);

int[] myArray = CreateArray(m);

Console.WriteLine("Среди данных введенных чисел: " + string.Join(", ", myArray));
Console.WriteLine("Общее количество чисел больше нуля: " + PositiveCount(myArray));