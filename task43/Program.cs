// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// Формулы для нахождения координат:
// x = (b1 - b2)/(k2 - k1)
// y = k2 * x + b2

double[] IntersectionPoint (double b1, double k1, double b2, double k2)
{
    double x = Math.Round((b1 - b2)/(k2 - k1), 1);
    double y = Math.Round(k2 * x + b2, 1);
    double[] array = {x,y};
    return array;
}

Console.WriteLine("Даны две прямые, заданные уравнениями:");
Console.WriteLine("Первая прямая y = k1 * x + b1");
Console.WriteLine("Вторая прямая y = k2 * x + b2");

Console.WriteLine("Введите значения для уравнений двух отрезков, чтобы найти точку их пересечения:");
Console.Write("Введите b1: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите k1: ");
int k1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите b2: ");
int b2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите k2: ");
int k2 = int.Parse(Console.ReadLine()!);

Console.Write($"Точка пересечения: ({string.Join("; ", IntersectionPoint(b1, k1, b2, k2))})");