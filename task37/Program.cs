// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//  Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3
//  [6 7 3 6] -> 36 21

int InputNumber()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void CreateArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 10);
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
void MultArray(int[] arr)
{
    int mult = 1;
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        if(i != size -1)
        {
        mult = arr[i] * arr[size - 1];
        size--;
        Console.Write($"{mult} ");
        }
        else Console.Write($"{arr[i]} ");
    }
}
int size = InputNumber();
int[] array = new int[size];
CreateArray(array);
PrintArray(array);
MultArray(array);