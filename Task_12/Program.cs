// Задача 12. Удалить вторую цифру трёхзначного числа

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int A = int.Parse(Console.ReadLine());
int B = A/100;
int C = (A % 100) % 10;
Console.Write(B);
Console.WriteLine(C);
