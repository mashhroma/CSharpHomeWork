// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int FiguresSum(int number)
{
    int sum = 0;
    if (number < 0) number = -number;
    for (int i = 0; number > 0; i++)
    {
        sum = sum + number % 10;
        number = number / 10;
        //Console.WriteLine(i + "|" + sum);
    }
    return sum;
}

Console.WriteLine("Данная программа суммирует цифры в заданном числе.");

Console.Write("Введите число:");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма цифр в числе {num} равна: {FiguresSum(num)}.");