// Напишите программу вычесления функции Аккермана с помощью рекурсиию Даны два неотрицательных числа(м и n).

Console.WriteLine("Введите два положительных числа: M и N.");

int m = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");




int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}
