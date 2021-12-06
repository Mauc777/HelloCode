// Программа проверяет пятизначное число на палиндромом.
Console.Clear();
Console.Write("Enter Num: ");
string x= Console.ReadLine();

     if (x[0] == x[4]  &&  x[1] == x[3])
     {
        Console.WriteLine("Палиндром"); 
     }
     else
     {
           Console.Write("Не палиндром");
     }

