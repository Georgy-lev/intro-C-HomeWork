// **Задача 69:**Напишите программу,
//  которая на вход принимает два числа A и B,
//   и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5-> 243(3⁵)

// A = 2; B = 3-> 8
int res=1;
int Multiply(int a, int b){
    if (b == 0)    {
        return a;    }
     res*= a;
    
    b-=1;
    Multiply(a, b);
    return res;
}
    
WriteLine(Multiply(5, 4));
