//Показать четные числа от 1 до N

int[] FillArray()
{
    int[] array = new int[10]; // объявл пуст массива с размером 10
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10); //каждому элементу присваем рандом число
    }
    
    return array; // обязательно возвращаем полученный массив??!!!!!!!
    
}

int[] Find(int[] ArrayA)
{
    int[] ArrayB = new int[0];
    int j = 0;


    for (int i = 0; i < ArrayA.Length; i++)  //??
    {
        if (ArrayA[i] % 2 == 0)
        {
            int Length = ArrayB.Length;
            Array.Resize(ref ArrayB, Length + 1);
            ArrayB[j] = ArrayA[i];

            j++;
        }
    }
    return (ArrayB);
}

void PrintArray(int[] ArrayA, int[] ArrayB)
{
    Console.Write("[");
    for (int i = 0; i < ArrayA.Length; i++)
    {
        Console.Write(ArrayA[i]);
        if (i != ArrayA.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("] -> [");
    for (int i = 0; i < ArrayB.Length; i++)
    {
        Console.Write(ArrayB[i]);
        if (i != ArrayB.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

void ArrayCheck(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
}

int[] ArrayA = FillArray();
// int[] ArrayB = Find(ArrayA);
ArrayCheck(ArrayA);
// Console.WriteLine();
// ArrayCheck(ArrayB);

PrintArray(ArrayA, Find(ArrayA));


























































// Console.Clear();
// int[] ArrayA = { 12, 13, 18, 20, 28, 36, 88, 90 };


// int[] FillArray(int[] ArrayA)
// {
//     int[] ArrayB = new int[0];
//     int j = 0;
//     int Length = ArrayB.Length;

//     for (int i = 0; i < ArrayB.Length; i++)
//     {
//         if (ArrayA[i] % 2 == 0)
//         {
//             ArrayA[i] = ArrayB[j];
//             Length = Length + 1;
//             j++;
//         }
//     }
//     return (ArrayB);
// }

// void PrintArray(int[] ArrayA, int[] ArrayB)
// {
//     for (int i = 0; i < ArrayA.Length; i++)
//     {
//         Console.Write($"{ArrayA[i]} ");
//         if (i != ArrayA.Length - 1)
//         {
//             Console.Write(",");
//         }
//     }
//     Console.WriteLine();

//     for (int i = 0; i < ArrayB.Length; i++)
//     {
//         Console.Write($"{ArrayB[i]} ");   
//         if (i != ArrayB.Length - 1)
//         {
//             Console.Write(",");
//         }
//     }

// }

// PrintArray(ArrayA, FillArray(ArrayA));












