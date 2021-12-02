
// Дано число. Проверить кратно ли оно 7 и 23

Console.Clear();
//NumA это число для вычисления кратности
Console.WriteLine("Enter numA ");
double A = double.Parse(Console.ReadLine());

double B = 7;
double C = 23;

while (A % B==0)
{
   Console.WriteLine("число кратно {B} ");
   break;    
} 

if (A % C ==0)
{
   Console.WriteLine("Число кратно {C} ");
   //break;
}




