// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int[] numbers = new int[3]{22, 3, 9}; 
int max = numbers[0]; 
for (int index = 0; index < numbers.Length; index++) 
{ 
 if (numbers[index] > max) max = numbers[index]; 
} 
Console.WriteLine("Максимальное число = " +max);
