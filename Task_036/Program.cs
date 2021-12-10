//36. Задать массив, заполнить случайными 
//положительными трёхзначными числами. Показать количество нечетных\четных чисел

//Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел
Console.Clear();
int[] FillArray()
{
    int[] array = new int[new Random().Next(5, 20)];//объявление пустого массива с длинной k

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($"A[{i}]={array[i]}; ");
    }
    return array;
}
int[] array2 = FillArray();
int count1 = 0;
int count2 = 0;
    for (int i = 0; i < array2.Length; i++)
{
    if (array2[i] %2== 0)
    {
        count1 = count1 + 1;
    }
    else 
    {
        count2 = count2 +1;
    }
}

Console.WriteLine($"\n Количество четных: {count1}, \n Количество нечетных: {count2}");
