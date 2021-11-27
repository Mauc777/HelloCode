//Показать четные числа от 1 до N

Console.Clear();
int[] num = {1, 200};
void FillArray(int[] collect);

{
    int lenght = num.Length;
    int index = 0;
    while (index < lenght)
   
    {
        if(num[index]%2 == 0)
        {
            FillArray(collect);
        }
        
        else
            {
            num[index]%2 ! = 0;
            Console.WriteLine();
            }
     index++;
    }        
}
FillArray(array);
PrintArray(array);
Console.WriteLine();      







