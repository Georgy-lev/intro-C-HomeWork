﻿// Напишите прорамму, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа
Console.Clear();

int num = new Random().Next(100,1000);//num = 254
int a1 = num / 10; // a1 = 254 / 10 = 25
int a2 = a1 % 10; // a2 = 25 % 10 = 5

Console.WriteLine($"Вторая цифра цифра числа {num}-> {a2}");