// **Задача 65:**Задайте значения M и N.
//  Напишите программу, которая выведет все
//   натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"


Write("Ent M: "); int m = int.Parse(ReadLine()!);
Write("Ent N: "); int n = int.Parse(ReadLine()!);
string PrintNums(int m, int n){ 
    if (m==n)
    {
        WriteLine(m);
        return m.ToString();
    }
    string res = PrintNums(m, n-1)+" "+n.ToString();
    WriteLine(res);
    return res;
}
