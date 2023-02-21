//30 Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.

//[1,0,1,1,0,1,0,0]
// a = new Random().Next()
// int a = new Random().Next(2)

int[] arr_a(int length_arr){
    int[] arr = new int[length_arr];
    for(int i = 0; i < arr.Length; i ++){
    arr[i] =  new Random().Next(2);
    Console.Write($"{arr[i]}, ");
}
    return arr;
}
Console.WriteLine("Введите размер массива : ");
int num = int.Parse(Console.ReadLine()!);
int[] d = arr_a(num);
