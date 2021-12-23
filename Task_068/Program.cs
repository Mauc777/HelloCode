//  Показать натуральные числа от M до N, N и M заданы
void NNumbers(int N, int M)
{
    if (M == N) { Console.WriteLine(M); return; }
    if (M < N) { Console.WriteLine(M); NNumbers(N, M + 1); }
    else if (M > N) { Console.WriteLine(M); NNumbers(N, M - 1); }
}
NNumbers(10, 2);
