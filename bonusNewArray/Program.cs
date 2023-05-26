//Создать массив из 10 элементов Удалить дубликаты 

//сделано с помощью 3х массивов, на самом деле можно обойтись и 2мя массивами. Работает только для положительных
// можно обойтись без метода CreateArrayNullEnd, тем самым сократив количество массивов
// просто добавив в этом методе CreateArrayNoDopl проверку на != -1 

void CreateArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 5);
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
void DopleInNull(int[] arr) //нахождение повторяющихся элементов с последующей заменой дубликатов
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] == arr[j])
            {
                arr[i] = -1;
            }
        }
    }
}
int SizeNewArray(int[] arr) //нахождение размера нового, меньшего массива
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++){
        if(arr[i] != -1){
            count++;
        }
    }
    return count;
}
void CreateArrayNullEnd(int[] arr, int[] newArr) //метод игнорирует все -1 и записывает только уникальные числа
{
    for (int i = 0, j = 0; i < arr.Length; i++, j++) //тут используется в индекса, так как нам необходимо записывать во второй массив по порядку
    {                  
        if (arr[i] != -1)
        {
            newArr[j] = arr[i];
        }
        else    //массив [5, 1, -1, -1, 2] индекс i [0, 1, 2, 3, 4], индекс j [0, 1, 1, 1, 2] запись в индексы 0, 1, 2. 
        {       // вывод [5, 1, 2]
            j--; //тут он уменьшается, но при переходе в начало цикла, он становиться +1. Вывод выше пример из else
        }
    }
}
void CreateArrayNoDopl(int[] arr, int[] newArr) //перезапись в массив с меньшим размером
{
    for (int i = 0; i < newArr.Length; i++) 
    {
        newArr[i] = arr[i];
    }
}
//1 5 9 0 8 8 2 8 9 5 
//1 5 9 0 8 2
int size = 10;
int[] array = new int[size];
int[] arrayN = new int[size];

CreateArray(array);
PrintArray(array);

DopleInNull(array);
PrintArray(array);

int newSize = SizeNewArray(array);
int[] newArray = new int[newSize];

CreateArrayNullEnd(array, arrayN); //можно обойтись и без него
PrintArray(arrayN);

CreateArrayNoDopl(arrayN, newArray);
PrintArray(newArray);
