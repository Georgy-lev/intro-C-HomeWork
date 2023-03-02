// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве
int [] arr = new int[5];
for (int i = 0; i< arr.Length; i++)
    arr[i]= new Random().Next(10);
    Console.WriteLine(String.Join(" ", arr));

Console.WriteLine("Введие число: ");  
int num= int.Parse(Console.ReadLine()!); 
if (arr.Contains(num)){
    Console.WriteLine($"Число {num} присутствует в массиве");
}
else
{
    Console.WriteLine($"Число {num} отсутствует в массиве");
}