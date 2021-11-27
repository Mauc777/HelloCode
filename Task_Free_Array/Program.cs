void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;    
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}


int[] array = new int[10];

FillArray(array);
PrintArray(array);


// делал пошаглово разбираясь в "слоях и блоках" кода раздельно, сделал вывод 
// ..что  первый void не работает без второго void-a!!
// и также наоборот, то есть нам нужно задать в функциях что мы хотим потом их вызывая поименно 
// ..получать нужные значения!!  !!wq!!!

















