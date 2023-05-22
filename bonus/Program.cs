//Создать массив из 10 элементов Удалить дубликаты 

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
void DeleteDuplicate(int[] array)
{
    for (int x = 0; x < array.Length; x++)
    {
        for (int z = 0; z < array.Length; z++)
        {
            if (x != z && array[x] == array[z]) array[z] = -1;
        }
        if (array[x] != -1) Console.Write($"{array[x]} ");
    }
}
//1 5 9 0 8 8 2 8 9 5 
//1 5 9 0 8 2
int size = 10;
int[] array = new int[size];
CreateArray(array);
PrintArray(array);
DeleteDuplicate(array);
