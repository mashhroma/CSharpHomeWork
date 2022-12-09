// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponentiation(int number, int degree)
{
    int result = 1;
    for (int i = 1; i <= degree; i++)
    {
        result = result * number;
        //Console.WriteLine(i + " | " + result);
    }
    return result;
}

Console.WriteLine("Введите два числа: само число и натуральную степень, в которую это число нужно возвести.");
Console.Write("Число: ");
int numA = int.Parse(Console.ReadLine()!);

Console.Write("Степень: ");
int numB = int.Parse(Console.ReadLine()!);

while (numB < 0)
{
    Console.Write($"Число {numB} не натуральное, введите натуральное число: ");
    numB = int.Parse(Console.ReadLine()!);
}

Console.WriteLine();
Console.WriteLine($"Число {numA} в степени {numB} равно {Exponentiation(numA, numB)}.");