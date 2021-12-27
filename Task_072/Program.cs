// 72. Написать программу возведения числа А в целую стень B

double NumDegree(double a, int b)
{
    if (b == 0)
    {
        return 1;
    }
    if (b < 0)
    {
        return NumDegree(a, b + 1) / a;
    }
    return NumDegree(a, b - 1) * a;
}
Console.WriteLine(NumDegree(2, 3));