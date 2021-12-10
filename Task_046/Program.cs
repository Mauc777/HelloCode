// 46. Написать программу масштабирования фигуры
// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

// Console.Write($"({X[IndexX]*k},");
string s = (Console.ReadLine());
// if ()
// Console.Write($"({X[IndexX]*k},");
double k = 2;
char[] separators = new char[] { ' ', ',', '(', ')' };
string[] Nums = (s.Split(separators, StringSplitOptions.RemoveEmptyEntries));

int[] X = new int[(Nums.Length) / 2];
int[] Y = new int[(Nums.Length) / 2];

for (int i = 0; i < Nums.Length; i++)
{
    int Index = 0;

    if (i % 2 == 0)
    {
        X[Index] = (Convert.ToInt32(Nums[i]));

        Console.Write($"({X[Index] * k},");

    }
    else
    {
        Y[Index] = (Convert.ToInt32(Nums[i]));

        Console.Write($" {Y[Index] * k}) ");

        // if (X[
    };
}    
