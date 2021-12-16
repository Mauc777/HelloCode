//Найти расстояние между точками в пространстве 2D/3D
Console.Clear();
double Dist (double x, double y, double z)

{
    double XYZ = Math.Round(Math.Sqrt(Math.Pow(x,2)+ Math.Pow(y,2)+ Math.Pow(z,2)));
    return XYZ;
}

Console.Write("Какое пространство 2D или 3D? (2/3): ");
int count = Convert.ToInt32(Console.ReadLine());

if (count !=2 && count !=3) 
{
    Console.Write("Недопустимое значение");
    return;
}


double x =0;
double y =0;
double z =0;

for (int i = 0; i < 2; i++)
{
    Console.Write($"Введите координату X точку №{i+1}: ");
    x = Convert.ToInt32(Console.ReadLine()) - x;
    
    Console.Write($"Введите координату Y точку №{i+1}: ");
    y = Convert.ToInt32(Console.ReadLine()) - y;
    


    if (count == 3)
    {
            Console.Write($"Введите координату Z точку №{i+1}: ");
    z = Convert.ToInt32(Console.ReadLine()) - z;
    }
    Console.WriteLine($"Координаты точки №{i+1}: ({x}, {y}, {z}) ");
}

Console.WriteLine($"Расстояние между точками равно: {Dist(x,y,z)}");
