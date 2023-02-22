Console.Clear();
Console.Write("A: ");
double A = double.Parse(Console.ReadLine()!);
Console.Write("B: ");
double B = double.Parse(Console.ReadLine()!);

double D = Math.Pow(A ,  B);
Console.WriteLine($"{A} в степени {B} = {D:f2}");