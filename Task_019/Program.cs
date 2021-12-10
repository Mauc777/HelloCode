// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, 
//причем X ≠ 0 и Y ≠ 0

Console.Clear();
Console.WriteLine("Введите координату Х от -20 до 20, не равную 0: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y от -20 до 20, не равную 0: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0)Console.WriteLine("Значения введены неправильно!");
if (x > 0 && y > 0) Console.WriteLine($" Точка с координатами x = {x}, y = {y} находится в 1 четверти");
if (x < 0 && y > 0) Console.WriteLine($" Точка с координатами x = {x}, y = {y} находится в 2 четверти");
if (x < 0 && y < 0) Console.WriteLine($" Точка с координатами x = {x}, y = {y} находится в 3 четверти");
if (x > 0 && y < 0) Console.WriteLine($" Точка с координатами x = {x}, y = {y} находится в 4 четверти");
