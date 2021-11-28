string Method4(int count, string text)
{
    //int i =0; это уже есть в for
    //string result = "";   //""; = такое значением обозначается значение пустая строка.
    string result = String.Empty; // = также обозначает пустая строка, но оно и из перевода понятно
    for (int i = 0; i < count; i++)
    // while (i < count)  это тоже содержиться уже в for
    {
        result = result + text;
        // i++;  это уже есть в for
    }
    return result;

}
string res = Method4(15, "Gamburg_show");
Console.WriteLine(res);