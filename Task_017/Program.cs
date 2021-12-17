//17 По двум заданным числам проверять является ли одно квадратом другого
Console.Clear();
int NumberA = 12;
int NumberB = 144;
int result = 0;

result = result + (int)Math.Pow(NumberA, 2);

if (result == NumberB)
{
    Console.Write($"Данное число {NumberA} является квадратом {NumberB}");
}
else
{
    Console.Write($"Данное число {NumberA} НЕ является квадратом {NumberB}");
}



