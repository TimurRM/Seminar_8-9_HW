// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


Console.Write("Введите число строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: "); 
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
GetArray(array);
Console.WriteLine($"\nДвумерный массив:");
PrintArray(array);

void GetArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
   {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
int SumOfRow(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

int minSum = 0;
int sumLine = SumOfRow(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int var = SumOfRow(array, i);
  if (sumLine > var)
  {
    sumLine = var;
    minSum = i;
  }
}

Console.WriteLine($"\n Строкa # {minSum+1}\n Сумма элементов строки {minSum+1} = {sumLine}");






