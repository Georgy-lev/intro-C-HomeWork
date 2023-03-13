// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. ВЫполнить с помощью рекурсии.
Console.Clear();
Console.Write("Введите натуральное число ");
int n = int.Parse(Console.ReadLine()!);

int m = 1;

Console.WriteLine(NaturalNumber(n, m));

int NaturalNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}

