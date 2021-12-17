//51. Задать двумерный массив следующим правилом: Aₘₙ = m+n
Console.Clear();
int m = 110;
int n = 115;
int[,] arr = new int[n, m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        arr[i,j] = i+j;
        Console.Write($" {arr[i, j]} ");
        
    }
    Console.WriteLine();
}
