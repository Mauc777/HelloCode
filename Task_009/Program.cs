//9. Показать последнюю цифру трёхзначного числа
Console.Clear();
int[] arrayA = { 158, 585, 685, 784, 108, 955, 16 };
for (int i = 0; i < arrayA.Length; i++)
{
    if (arrayA[i] >= 100)
    {
        Console.Write('[');
        Console.Write(arrayA[i] % 10);
        Console.Write(']');
    }

}
Console.WriteLine("[конец]");

// Console.Clear();
// var numberA = 156;
// Console.WriteLine($"{numberA % 10}");
// Console.WriteLine("Конец бля");
