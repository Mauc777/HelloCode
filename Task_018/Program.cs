//18 Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
Console.Clear();
bool x, y;
x = true;
y = true;

bool result = true;


if (!(x || y) == (!x && !y) )
{
    Console.WriteLine(true);    

} 

else result = false;


x = true;
y = false;

if (!(x|| y) == (!x && !y) )
{
    Console.WriteLine(true);    
} 
else result = false;

x = false;
y = true;
if (!(x|| y) == (!x && !y) )
{
    Console.WriteLine(true);    
} 
else result = false;

x = false;
y = false;
if (!(x|| y) == (!x && !y) )
{
    Console.WriteLine(true);    
} 
else result = false;

if (result)
Console.WriteLine($"Утверждение Истинно"  );
else
{
    Console.WriteLine($"Утверждение НЕ Истинно"  );    
}
