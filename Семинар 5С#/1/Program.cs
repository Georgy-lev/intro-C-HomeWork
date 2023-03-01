// Задайте массив из 12 элементов, заполненый случайными числами из промежутка [-9,9]
// Найдите сумму отрицательных и положительных элементов массива.

int [] array = GetRandomArray(12,-9,9);
Console.WriteLine(String.Join(", ", array));
int [] SumPosNeg(int[] array)
{
    int [] result = new int [2];
    foreach (int el in array)
    {
        result[0] += el >0 ? el:0;
        result[1] += el<0 ? el:0;
    }
    return result;


}   
//for (int i = 0; i< array.Lenght;i++){
//    int el = array[i];
//if (el>0)
//    positiveSum+=el;
//else
//    positiveSum+=0;
//if (el<0)
//    negativeSum+=el;
//else 
//    negativeSum+=el;
//}
Console.WriteLine($"Positive sum = {SumPosNeg(array)[0]},  Negative sum = {SumPosNeg(array)[1]}");

int [] GetRandomArray(int size, int minValue, int maxValue)
{
    int [] result = new int[size];
    for (int i = 0; i<size;i++)
    {
        result[i] = new Random().Next(minValue,maxValue+1);
    }
    return result;
}