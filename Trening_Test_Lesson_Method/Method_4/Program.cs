

string Method4(int count, string text)
{
    int i =0;
    //string result = "";   //""; = такое значением обозначается значение пустая строка.
    string result = String.Empty; // = также обозначает пустая строка, но оно и из перевода понятно

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;

}
string res = Method4(15, "Gamburg_show");
Console.WriteLine(res);