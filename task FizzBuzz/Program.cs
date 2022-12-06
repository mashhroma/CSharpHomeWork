// Задача:
// Напишите программу, которая выводит на экран числа от 1 до 100.
// При этом вместо чисел, кратных трем, программа должна выводить слово «Fizz»,
// а вместо чисел, кратных пяти — слово «Buzz».
// Если число кратно и 3, и 5, то программа должна выводить слово «FizzBuzz»

int num = 1;

for (int i = 0; i < 100; i++)
{
    num = i + 1;
    if (num % 5 == 0 && num % 3 == 0) Console.Write("FizzBuzz ");
    else if (num % 3 == 0) Console.Write("Fizz ");
    else if (num % 5 == 0) Console.Write("Buzz ");
    else Console.Write($"{num} ");
}