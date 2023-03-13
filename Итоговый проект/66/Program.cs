// Задайте значения M и N. Напишите программу, которая найдет сумму натуральных жлементов в промежутке от M до N.

Console.WriteLine("Введите M:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите N:");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");






int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return m + CountNaturalSum(m+1, n);
}