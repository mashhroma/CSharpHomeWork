// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите три числа, чтобы их сравнить.");

Console.Write("Первое число (a): ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Второе число (b): ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Второе число (c): ");
int c = int.Parse(Console.ReadLine()!);

int max = 0;

if (max < a) max=a;
if (max < b) max=b;
if (max < c) max=c;

Console.WriteLine($"a = {a}, b = {b}, c = {c} -> max = {max}");