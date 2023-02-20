// Напишите программу, которая принимает на вход пятизначное число 
//  и проверяет, является ли оно полиндромом.

//14212-> нет
//12821-> да
//23432-> да

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int a1 = number / 10000; 
int a5 = number %10;
int a2 = number / 1000 % 10;
int a4 = number %100 / 10;

if (a1==a5|| a2==a4)
    Console.WriteLine("Число является полиндромом");
else
{
    Console.WriteLine("Число не является полиндромом");
}