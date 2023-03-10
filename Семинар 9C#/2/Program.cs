/***Задача 67:**Напишите программу, 
которая будет принимать на вход число и возвращать сумму его цифр.

453 -> 12

45 -> 9*/


Write("Ent NUM: "); int num = int.Parse(ReadLine());
int sum=0;
int Num(int number){
    if (number == 0)
    {
        return number;
    }
     sum += number%10;
    number=number/10;
    Num(number);
    return sum;}

WriteLine(Num(num));
