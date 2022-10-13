Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max < b)
{
    max = b;
}
else 
{
    max = max;
}
if (max < c)
{
    max = c;
}
else 
{
    max = max;
}
Console.Write($"Макс. число {max}");