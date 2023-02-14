// Напишите программу, которая выводит случайное число из отрезка [10,99]
Console.Clear();

int num = new Random().Next(10,100);//num = 25
int a1 = num / 10; // a1 = 25 / 10 = 2
int a2 = num %10 // a2 = 25 % 10 = 5
int max = a1;
if (max < a2)
    max = a2;
Console.WriteLine($"Максимальная цифра числа {num}-> {max}");
