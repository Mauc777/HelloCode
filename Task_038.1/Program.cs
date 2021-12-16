// Найти сумму чисел одномерного массива стоящих на нечетной позиции
Console.Clear();
int[] FillArray()
{
int[] array = new int[new Random().Next(0, 20)];//объявление пустого массива с длинной k

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
        Console.Write($"A[{i}]={array[i]}; ");
    }
    return array;
}
int[] array2 = FillArray();

int sum = 0;
for (int i = 0; i < array2.Length; i++)
{
    if (i%2==1)
    {
         sum = sum + array2[i];
    }

}
Console.WriteLine($"\nСумма элементов {sum}");
