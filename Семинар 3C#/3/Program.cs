// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.

// 2 -> 1,4

Console.Clear();
Console.Write("Введите число: ");
double number = double.Parse(Console.ReadLine());

for (double i = 1; i <= number; i++) 
{
  double result = Math.Pow(i, 2);
  Console.WriteLine($"{number} -> {result}");
}
