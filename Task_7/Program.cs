//Показать числа от -N до N

Console.WriteLine("Enter num");
int FirstNum = int.Parse(Console.ReadLine());
int NextNum = -FirstNum;
    while (NextNum <= FirstNum)
    {
       Console.WriteLine(NextNum);
       NextNum++; 
    }

// задача решена совмиестнвми усилиями на семинаре