// Напишите программу, которая принимает на вход два числа и проверяет, 
//является ли одно квадратом другого
Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine() !);
int number2 = int.Parse(Console.ReadLine() !);

int square = number1*number1;
int square2 = number2*number2;


if ( square == number2||square2 == number1)
    Console.WriteLine("Число являеся квадратом второго");
else
{
    Console.WriteLine("Не является");
}
