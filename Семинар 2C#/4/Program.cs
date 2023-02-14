// Напиите программу, которая принимает на вход число и проверяет, критно
// ли оно одновременно 7 и 23.

int number = int.Parse(Console.ReadLine() !);

int number1 = 7;
int number2 = 23;

if ( number % number1 == 0 || number % number2 == 0)
    Console.WriteLine("Число кратно 7 и 23");
else
{
    Console.WriteLine("Число некратно");
}

