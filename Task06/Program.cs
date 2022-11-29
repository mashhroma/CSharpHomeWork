// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите, пожалуйста, число, чтобы узнать четное оно или нечетное: ");
int number = int.Parse(Console.ReadLine()!);

int divNumber = number%2;

if (divNumber == 0)
{
    Console.WriteLine($"Число {number} - четное");
}
else
{
    Console.WriteLine($"Число {number} - нечетное");
}