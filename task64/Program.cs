// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string PrintNumbers(int n)
{
    if (n == 1) return $"{n}";
    else return $"{n} {PrintNumbers(n - 1)}";
}

Console.WriteLine("Программа выводит на экран все числа от заданного числа до 1.");
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if (number <= 0) Console.WriteLine("Вы ввели число меньше 1.");
else Console.WriteLine(PrintNumbers(number));