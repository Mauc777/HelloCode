﻿// Задание: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.
// примеры:
// ["hello", "2", "world", ":-)"] -> ["2",":-)" ]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []
Console.Clear();
string[] ArrayStrings = {"1242", "1567", "-5222", "computer science"};

string[] Selection(string[] ArrayStrings)
{
    string[] ArrayFinite = new string[0];
    int j = 0;
    for (int i = 0; i < ArrayStrings.Length; i++)
    {
        if (ArrayStrings[i].Length <= 3)
        {
            int lenght = ArrayFinite.Length;
            Array.Resize(ref ArrayFinite, lenght + 1);
            ArrayFinite[j] = ArrayStrings[i];
            j++;

        }
    }
    return (ArrayFinite);
}

void WriteArray(string[] ArrayStrings, string[] ArrayFinite)

{
    Console.Write("[");
    for (int i = 0; i < ArrayStrings.Length; i++)
    {
        Console.Write(ArrayStrings[i]);
        if (i != ArrayStrings.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("] -> [");
    for (int i = 0; i < ArrayFinite.Length; i++)
    {
        Console.Write(ArrayFinite[i]);
        if (i != ArrayFinite.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

WriteArray(ArrayStrings, Selection(ArrayStrings));