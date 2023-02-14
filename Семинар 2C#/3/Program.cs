//Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если второе число не кратно числу первому,
//то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно


int number1 = int.Parse(Console.ReadLine() !);
int number2 = int.Parse(Console.ReadLine() !);
int num = 0;
int diff = number1%number2;
if (diff == 0)
    Console.WriteLine("Число кратно 5");
else 
{    
    num = diff%5;
    Console.WriteLine($"Число не кратно, остаток - {num}");
}

