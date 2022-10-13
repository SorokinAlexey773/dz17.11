Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = a;
if (a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}
Console.WriteLine($"Макс. число = {max}");
Console.Write($"Мин. число = {min}");