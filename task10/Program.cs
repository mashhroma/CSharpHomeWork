// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Данная программа возвращает вторую цифру трехзначного числа.");
Console.Write("Введите трехзначного число: ");
int addedNum = int.Parse(Console.ReadLine()!);

if ((addedNum >=-999 && addedNum <= -100) || (addedNum >=100 && addedNum <= 999))
{
    int num = addedNum / 10;
    int printedNum = num % 10;
    if (printedNum < 0) printedNum = -printedNum;
    Console.WriteLine($"Вторая цифра трехзначного {addedNum} числа - это {printedNum}.");
}
else
{
    Console.WriteLine($"Введенное число {addedNum} не является трехзначным.");
}