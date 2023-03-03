//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
int [] startArray = GetArray(4, 100, 999);

int sum = GetMaxElements(startArray) + GetMinElements(startArray);
Console.WriteLine($"Сумма max и min элементов массива  = {sum}");

int [] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int[size];

    for (int i = 0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}
int GetMaxElements(int[] array)
{
    int max = 0;   
        for (int i =0; i<array.Length; i++)
            if (array[i]>max)
            array[i]=max; 
        return max;
}
int GetMinElements(int[] array)
{
    int min = 0;   
        for (int i =0; i<array.Length; i++)
            if (array[i]<min)
            array[i]=min; 
    return min;
}