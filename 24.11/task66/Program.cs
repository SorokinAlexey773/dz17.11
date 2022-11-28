// // Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
//  Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Введите 1 натуральное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = SumNumbers(m, n) + n;
Console.WriteLine(sum);
int SumNumbers(int m, int n)
{
    if (m == n) return 0;
    return m + SumNumbers(m + 1, n);

}
