// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine() !);;//num = 254

int a3 = number % 10; // a2 = 25 % 10 = 5


if (number<100)
    Console.WriteLine("Третьего числа нет");
else
{
    Console.WriteLine($"Вторая цифра цифра числа {number} -> {a3}");
}