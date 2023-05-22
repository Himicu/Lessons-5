// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в 
// отрезке [10,99]. Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123 [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0 [10, 11, 12, 13, 14] -> 5

int InputNumber()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void CreateArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 200);
    }
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
int ConterSigment(int[] arr){
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 9 && arr[i] < 100){
            count++;
        }
    }
    return count;
}
int size = InputNumber();
int[] array = new int[size];
CreateArray(array);
PrintArray(array);
System.Console.WriteLine(ConterSigment(array));  