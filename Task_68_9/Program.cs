// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.Write("Введите число m: ");
Int64 m = Convert.ToInt64(Console.ReadLine());
Console.Write("Введите число n: ");
Int64 n = Convert.ToInt64(Console.ReadLine());

Console.Write($"M = {m}; N = {n} -> A(m,n) = {Akkerman (m , n)}");

Int64 Akkerman (Int64 m , Int64 n)
{
    if ( m < 0 ||  n < 0) return 0;
    
    else if (m == 0) return n + 1;
        
    else if (m > 0 && n == 0) return Akkerman(m - 1, 1);
        
    else return Akkerman(m-1, Akkerman(m, n - 1));
        
}


