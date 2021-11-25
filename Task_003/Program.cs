Console.Clear();
string[] Weeks = {" ","Mon","Thu","Wen","Thr","Fra","Sat","sun"};
Console.Write("Введите номер дня недели: ");
int index = int.Parse(Console.ReadLine());
Console.WriteLine(Weeks[index]);
