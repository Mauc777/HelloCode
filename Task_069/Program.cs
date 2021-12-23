// 69. Найти сумму элементов от M до N, N и M заданы
Console.Clear();
void SumNum(int N, int M, int sum)
{
    if (M == N)
    {
        sum = sum + M; Console.WriteLine(M); Console.WriteLine($"Сумма элементов от M до N = {sum}");
        return;
    }
    if (M < N) { sum = sum + M; Console.WriteLine(M); SumNum(N, M + 1, sum); }
    else if (M > N) { sum = sum + M; Console.WriteLine(M); SumNum(N, M - 1, sum); }
}
SumNum(10, 2, 0);

