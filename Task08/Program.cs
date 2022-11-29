// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите, пожалуйста, число: ");
int maxNumber = int.Parse(Console.ReadLine()!);

int Number = 1;

Console.Write($"Все чётные числа от 1 до {maxNumber}:    ");

while (Number <= maxNumber)
{
    if (Number%2 == 0)
    {
        Console.Write($"{Number}, ");
        Number++;
    }
    else
    {
        Number++;
    }
}
