// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");

var Num = Convert.ToDouble(Console.ReadLine()!);

if (Num > -10 && Num < 10) Console.WriteLine($"Число {Num} это палиндром.");
else
{
    double n = Math.Abs(Num);  //эту переменную буду изменять в цикле, чтобы изначальную переменную не трогать и вывести на экран.
    double i = 10;
    
    while (n / i > 10) i = i * 10;
    
    while (n > 10)
    {
        if (Math.Floor (n / i) != n % 10)
        {
            Console.WriteLine($"Число {Num} это НЕ палиндром.");
            break;
        }
        else if (n < 1000)
        {
            Console.WriteLine($"Число {Num} это палиндром.");
            break;
        }
        else
        {
            n = Math.Floor ((n - n % 10 * i) / 10);
            i = i / 100;
        }
    }
}