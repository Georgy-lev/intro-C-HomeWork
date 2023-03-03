// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();
int [] startArray = GetArray(4, 100, 999);
Console.WriteLine($"Сумма четных элементов массива  = {GetSumElements(startArray)}");

int [] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int[size];

    for (int i = 0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
        

    }
    return res;
}
int GetSumElements(int[] array)
{
int sum = 0;   
    for (int i =0; i<array.Length; i++)
        if (i%2==0)
            sum +=array[i]; 
        else
            sum+=0;
    return sum;
}
