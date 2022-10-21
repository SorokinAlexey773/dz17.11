// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// // 918 -> 1 
int SecondDigit (int number)
{
number = number / 10;
 return number = number % 10;
}
Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
{
    num = num * - 1;
}
int secondDigit = SecondDigit(num);
Console.WriteLine(num > 1000 ? "Некорректное число" : $"Вторая цифра числа {num} = {secondDigit} ");