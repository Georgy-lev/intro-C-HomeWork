// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N. 
// *при N<0, нужно вывести от N до -1

// 3 -> 1,8,27
// 5 1,8,27,64,125



Console.Clear();
Console.WriteLine("Введите число: ");
double number = double.Parse(Console.ReadLine()!);
for (double i = 1; i<= number; i++)
{
    double result = Math.Pow(i, 3);
    Console.WriteLine($"{i} -> {result}");
}
if (number < 0)
   for (double i = number; i<= -1; i++)
   {
        double result = Math.Pow(i, 3);
        Console.WriteLine($"{i} -> {result}");
   }