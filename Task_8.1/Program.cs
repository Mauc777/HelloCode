//Показать четные числа от 1 до N
//Показать четные числа от 1 до N

int[] FillArray()
{
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 20);
    }
   
    return array;
}

int[] Find(int[] ArrayA)
{
    int[] ArrayB = new int[0];
    int j = 0;
    

    for (int i = 0; i < ArrayA.Length; i++)
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
int []ArrayA=FillArray();
PrintArray(ArrayA, Find(ArrayA));


