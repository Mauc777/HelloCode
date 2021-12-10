//37 В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

Console.Clear();

int[] InitArray(int arrayLength)
{
    int[] array = new int[arrayLength];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i + 1;
    }
    return array;
}

void Print (int [] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
}

int[] array = InitArray(123);
Print(array); 

int count = 0;

for (int index = 0; index < array.Length; index++)
{
    if (array[index] >= 10 && array[index] <= 99)
    {
        count = count + 1;
    }
}
Console.WriteLine($"\n Количество элементов внутри отрезка от 10 до 99: {count}");
