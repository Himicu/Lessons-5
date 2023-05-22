// Задача 31: Задайте массив из 12 элементов, заполненный случайными 
// числами из промежутка [-9, 9]. Найдите сумму отрицательных и 
// положительных элементов массива.Например, в массиве 
// [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

void CreateArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 9);
    }
}
int SumNegativ(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            sum = sum + arr[i];
        }
    }
    return sum;
}
int SumPositive(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sum = sum + arr[i];
        }
    }
    return sum;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int[] array = new int[12];
CreateArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма отрицательных равна {SumNegativ(array)}, Сумма отрицательных равна {SumPositive(array)},");
