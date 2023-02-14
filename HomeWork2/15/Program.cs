// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine() !);
int [] mon = {6, 13, 20, 27};
int [] tue = {7, 14, 21, 28};
int [] wed = {8, 15, 22};
int [] thu = {2, 9, 16, 23};
int [] fri = {3, 10, 17, 24};
int [] sat = {4, 11, 18, 25};
int [] sun = {7, 14, 21, 26};


if (mon.Contains(number))
    Console.Write("Понедельник");
if (tue.Contains(number))
    Console.Write("Ворник");
if (wed.Contains(number))
    Console.Write("Среда");
if (thu.Contains(number))
    Console.Write("Четверг");
if (fri.Contains(number))
    Console.Write("Пятница");    
if (sat.Contains(number))
{
    Console.WriteLine("Суббота");
    Console.WriteLine("Выходной день");
}
if (sun.Contains(number))
{
    Console.WriteLine("Воскресенье");
    Console.WriteLine("Выходной день"); 
}  





    
    



