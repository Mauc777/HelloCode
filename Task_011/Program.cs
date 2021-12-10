//11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.Clear();
Console.WriteLine("Введите заданное число от 10 до 99");
int numberA = int.Parse(Console.ReadLine());
//Console.WriteLine(numberA);


int result1 = 0;
int result2 = 0;

for (int i = 0; i < 1; i++)
{
    result1 = result1 + numberA / 10;  //нахождение целого числа
    Console.WriteLine($"целое число от деления = {result1} ");
}
for (int j = 0; j < 1; j++)
{
    result2 = result2 + numberA % 10;  //нахождение остатка
    Console.WriteLine();
    Console.WriteLine($"остаток от деления на 10 равен = {result2} ");
}
if (result1 > result2)
{
    Console.WriteLine();
    Console.WriteLine($"наибольшей цифрой числа является 1-ое число = {result1} ");
}
else
{
    Console.WriteLine($"наибольшей цифрой числа является 2-ое число = {result2}");
}











