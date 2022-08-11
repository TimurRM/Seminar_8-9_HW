// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму целых чисел в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30
// M = -9; N = 8 -> -9

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"M = {m}; N = {n} -> {SumNum(m, n)}");

int SumNum(int m, int n)
{
    if (n > m)
    return n + SumNum (m, n - 1); 

    if (m > n)
    return m + SumNum (m - 1 , n);

    return m;         
}

  
     
        
       
        
   



