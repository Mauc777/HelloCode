//17 По двум заданным числам проверять является ли одно квадратом другого

// TODO написать медот для проверки на квадрат 
Console.Clear();
// int NumberA = 12;
// int NumberB = 144;
//int result = 0;
//int NumberA, int NumberB

int DedTop(int result = 0, int NumberA = 12, int NumberB = 144)
{
    //int result = 0;
    result = (int)Math.Pow(NumberA, 2);
    result = result + (int)Math.Pow(NumberA, 2);
    if (result == NumberB)
    {
        //Console.Write(result);
        Console.Write($"Данное число {NumberA} является квадратом {NumberB}");

    }


    else
    {
        Console.Write($"Данное число {NumberA} НЕ является квадратом {NumberB}");
    }
    return result;

}




Console.WriteLine(result);

