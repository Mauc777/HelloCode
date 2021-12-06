//Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Clear();
string[] Weeks = {"  ", "mon", "thu", "wen", "thr", "fra", "sat", "sun"};
Console.WriteLine("Enter number:  ");
int index = int.Parse(Console.ReadLine());
Console.Write(Weeks[index]);
if (index == 6 || index == 7 )
{
    Console.Write(" Выходной");
}

