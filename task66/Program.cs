// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ItemsSum(int m, int n)
{
    if (m == n) return m;
    if (m < n) return m + ItemsSum(m + 1, n);
    else return m + ItemsSum(m - 1, n);
}


Console.WriteLine("Программа выводит на экран сумму натуральных элементов в заданном промежутке.");
Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine()!);

Console.WriteLine(ItemsSum(numberA, numberB));