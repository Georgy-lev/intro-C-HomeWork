// Напишите прорамму, которая принимает на вход число 
// и выдает количество цифр в числе
// 456 -> 3
// 78 -> 2
//89126 -> 5


Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int count = 0;

while (n!=0)
{
    n=n/10;
    count++;
}
Console.WriteLine($"Количество цифр числа равна {count}");