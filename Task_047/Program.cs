//47. Написать программу копирования массива

Console.Clear();
int [] firstarray = new int[10];           //задаем массив  из 10 элементов
void FeelArray(int [] firstarray) //в методе FeelArray берем за аргумент массив 
                                    //int [] firstarray
{
    Console.WriteLine("Исходный массив");
    for (int i = 0; i < firstarray.Length; i++)
    {
        firstarray[i] = new Random().Next(0,100); //опред. элемент массива как Рандомный
    Console.Write(firstarray[i]+"; "); // даем искусственный разделитель ";" точкаСзапятой
    }
    Console.WriteLine(); // даем команду показать\отобразить что мы получили по оконч.работы
}

void CopyArray(int [] secondarray)
{
    Console.WriteLine("Скопированный массив");
    for (int j = 0; j < secondarray.Length; j++)
    {
        secondarray[j] = firstarray[j]; //присваеваем элементу из массива secondarray элемент
                                       // из массива firstarray
    Console.Write(secondarray[j]+"; ");
    }
    Console.WriteLine();
}

FeelArray (firstarray);
firstarray[5] = 1000;
CopyArray (firstarray);