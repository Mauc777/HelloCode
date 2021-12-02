Console.Clear();

void Find3Num(string NumberA)

{if (NumberA.Length > 2) Console.WriteLine($"Третья цифра числа: {NumberA[2]}");
else Console.WriteLine("Нет третьей цифры");}

Console.Write("Введите любое число: ");
//string NumberA = Console.ReadLine();

Find3Num(Console.ReadLine());
