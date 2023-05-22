// Задача 33: Задайте массив. 
// Напишите программу, которая определяет, присутствует ли заданное 
// число в массиве. 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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
void NumberSearch(int[] arr, int num)
{
    bool numSearch = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            numSearch = true;
            break;
        }
    }
    if(numSearch) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}
Console.WriteLine("Vvedite size: ");
int size = InputNumber();
int[] array = new int[size];
Console.WriteLine("Vvedite number serch: ");
int search = InputNumber();
CreateArray(array);
PrintArray(array);
NumberSearch(array, search);