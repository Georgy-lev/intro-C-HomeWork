// Напишите программу, которая выводит 1 и 3 число из трех значного числа
Console.Clear();

int num = new Random().Next(100,1000);//num = 25
int a1 = num / 100; // a1 = 25 / 10 = 2
int a3 = num % 10; // a2 = 25 % 10 = 5


Console.WriteLine($"Максимальная цифра числа {num}-> {a1} {a3}");
