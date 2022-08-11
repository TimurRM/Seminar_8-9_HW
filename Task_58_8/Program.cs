// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. 

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

void MultiplyArray(int[,] firstArray, int[,] secomdArray, int[,] productArray)
{
  for (int i = 0; i < productArray.GetLength(0); i++)
  {
    for (int j = 0; j < productArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstArray.GetLength(1); k++)
      {
        sum += firstArray[i,k] * secomdArray[k,j];
      }
      productArray[i,j] = sum;
    }
  }
}


Console.Write("Введите число строк первой матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов первой матрицы (= число строк второй матрицы): "); 
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов второй матрицы: "); 
int o = Convert.ToInt32(Console.ReadLine());

int[,] firstArray = new int[m, n];
GetArray(firstArray);
Console.WriteLine($"\nПервая матрица:");
PrintArray(firstArray);
int[,] secondArray = new int[n, o];
GetArray(secondArray);
Console.WriteLine($"\nВторая матрица:");
PrintArray(secondArray);

Console.Clear();
int[,] productArray = new int[m, o];
MultiplyArray(firstArray, secondArray, productArray);

Console.WriteLine($"\nПервая матрица:");
PrintArray(firstArray);
Console.WriteLine($"\nВторая матрица:");
PrintArray(secondArray);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintArray(productArray);