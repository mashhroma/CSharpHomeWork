// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int Number = 1;
Console.Write("Введите, пожалуйста, число больше единицы: ");
int maxNumber = int.Parse(Console.ReadLine()!);

while (maxNumber < 2)
{
    if (maxNumber == 0)
    {
    Console.WriteLine("Введенное число равно 0.");
    Console.Write("Введите, пожалуйста, число больше единицы: ");
    }
    else if (maxNumber ==1)
    {
    Console.WriteLine($"Введенное число равно 1.");
    Console.Write("Введите, пожалуйста, число больше единицы: ");
    }
    else
    {
    Console.WriteLine($"Введенное число {maxNumber} - меньше единицы.");
    Console.Write("Введите, пожалуйста, число больше единицы: ");
    }
    maxNumber = int.Parse(Console.ReadLine()!);
}

Console.Write($"Все чётные числа от 1 до введенного числа {maxNumber}:    ");
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