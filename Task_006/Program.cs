double numberA = new Random().Next(1, 30); // 1 2 3 4 ... 30

if (numberA %2== 0)
{
    Console.Write(numberA);
    Console.WriteLine(" Четное число");
}
else
{
    Console.Write(numberA);
    Console.WriteLine(" Нечетное");
}