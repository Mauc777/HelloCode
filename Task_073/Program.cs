// 73. Написать программу показывающие первые N чисел, для которых
//  каждое следующее равно сумме двух предыдущих. Первые два элемента 
//  последовательности задаются пользователем

int Num(int a, int b, int n)
{
    if (n == 1)
    {
        return a;
    }
    if (n == 2)
    {
        return b;
    }
    return Num(a, b, n - 1) + Num(a, b, n - 2);
}
int n = 5;
for (int i = 1; i < n; i++)
{
    Console.Write( $" {Num(4,3,i)} ");
}
//Console.WriteLine(Num(15,5,6));