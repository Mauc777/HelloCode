//Женя Одногрупп, [16.12.2021 14:00]
// Спирально заполнить двумерный массив:
//1  2  3  4
//12 13 14  5
//11 16 15  6
//10  9  8  7
Console.Clear();
int m = 5;
int n = 8;
int[,] arr = new int[n, m];
int j = 0;
int i = 0;
int s = 0;
int vitok = 0;
while (s < m*n)
{
while (j < arr.GetLength(1) - vitok)
{
    if (arr[i, j] == 0)
    {
        s = s + 1;
        arr[i, j] = s;
    }
    j++;

}
j = j - 1;
 while (i < arr.GetLength(0)- vitok)
{
    if (arr[i, j] == 0)
    {
        s = s + 1;
        arr[i, j] = s;
    }
    i++;
}
i = i - 1;
while (j >= 0 + vitok)
{
    if (arr[i, j] == 0)
    {
        s = s + 1;
        arr[i, j] = s;
    }

    j--;
}
j++;
while (i >= 0 + vitok)
{
    if (arr[i, j] == 0)
    {
        s = s + 1;
        arr[i, j] = s;
    }
    i--;
}
i++;
vitok++;
i++;
j++;
}
for (int k = 0; k < n; k++)
{
    for (int y = 0; y < m; y++)
    {
        Console.Write($"{arr[k, y]} ");

    }
    Console.WriteLine();
}