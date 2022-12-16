// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int PositiveCount(string text)
{
    int count = 0;
    for (int i = 0; i < text.Length; i++)
    {
        string res = string.Empty;
        while (text[i] != ',')
        {
            if (i == text.Length - 1)
            {
                res += text[i];
                break;
            }
            else
            {
                res += text[i];
                i++;
            }
        }
        if (Convert.ToInt32(res) > 0) count++;
    }
    return count;
}

Console.Write("Введите числа через запятую: ");
string numbers = Console.ReadLine()!;

Console.WriteLine($"Общее количество чисел больше нуля: {PositiveCount(numbers)}.");