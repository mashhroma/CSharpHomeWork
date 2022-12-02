// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Данная программа выводит третью цифру заданного числа.");
Console.Write("Введите число: ");
int AddedNum = int.Parse(Console.ReadLine()!);

if ( AddedNum > -100 && AddedNum < 100 )
{
    Console.Write($"У числа {AddedNum} третьей цифры нет.");
}
else
{
    int count = AddedNum;
    if (count < 0) count = -count;
    while (count > 1000)
    {
        count = count / 10;
    }
    int PrintNum = count % 10;
    Console.Write($"У числа {AddedNum} третья цифра: {PrintNum}.");
}