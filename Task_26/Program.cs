//Возведите число А в натуральную степень B используя цикл

Console.Clear();
Console.WriteLine("Enter numA ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Enter numB ");
int B = int.Parse(Console.ReadLine());
int result = 1;

for (int i = 0; i < B; i++)
{
    result =  result * A ;
}


 Console.WriteLine(B);
    Console.WriteLine(result);



