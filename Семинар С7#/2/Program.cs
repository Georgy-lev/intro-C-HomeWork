using System;
using static System.Console;
Write("Ввудите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Ввудите количество столбцов массива: ");
int column = int.Parse(ReadLine());
int [,] muss = GetArray(rows, column, 3, 4);
FealArray(muss);
PrintArray(muss);
void FealArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            inArray[i,j] = i+j;
        }
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}


