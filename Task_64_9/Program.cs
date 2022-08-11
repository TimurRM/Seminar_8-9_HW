// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());


Console.Write($"M = {m}; N = {n} -> ");
if (m < n)
    for (int i = m; i <= n; i++)
    Console.Write($" {i}");
else if (n < m)
    for (int i = m; i >= n; i--)
    Console.Write($" {i}");
else
    Console.WriteLine($" {n}");

 