// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
Console.Clear();
int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (i % 2 == 1)
    {
        
        sum = sum + arr[i];

    }
}
Console.WriteLine($"Сумма чисел нечетной позиции = {sum}");