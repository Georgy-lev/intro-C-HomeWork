// Напишите прорамму, которая принимает на вход число N
// и выдает произведение цифр в числе

int Get_Factorial(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    result*= i;
    return result;
}
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Факториал от 1 до {n} равна {Get_Factorial(n)}");