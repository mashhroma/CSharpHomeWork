// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки А в пространстве (x, y, z):");
Console.Write("xA: ");
var xA = double.Parse(Console.ReadLine()!);
Console.Write("yA: ");
var yA = double.Parse(Console.ReadLine()!);
Console.Write("zA: ");
var zA = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты точки B в пространстве (x, y, z):");
Console.Write("xB: ");
var xB = double.Parse(Console.ReadLine()!);
Console.Write("yB: ");
var yB = double.Parse(Console.ReadLine()!);
Console.Write("zB: ");
var zB = double.Parse(Console.ReadLine()!);

var distance = Math.Round(Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2)), 2);

Console.WriteLine($"Расстояние между точками равно: {distance}");