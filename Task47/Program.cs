// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
double[,] matrix = new double[rows, columns]; // rows = 3, columns = 4

Random rnd = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
       matrix[i, j] = rnd.Next(min, max + 1);
    }
  }
return matrix; 
}

void PrintMatrix(double [,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
Console.Write("|");
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write($"{matrix[i, j], 5}");
}
Console.WriteLine(" |");
 }
}

double[,] array2d = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2d);



// Console.WriteLine("Задайте количество строк двумерного массива:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Задайте количество столбцов двумерного массива:");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] twoDimArray = new double[m, n];
// Random rnd = new Random();
// void PrintArray(double[,] matr)
// { for (int i = 0; i < m; i++)
//  { for (int j = 0; j < n; j++)
//  { Console.Write($"{matr[i, j]} ");}
//  Console.WriteLine();}}

// void FillArray(double[,] matr)
// { for (int i = 0; i < m; i++)
//  { for (int j = 0; j < n; j++)
//  { matr[i,j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);}}}
// FillArray(twoDimArray);
// Console.WriteLine();
// PrintArray(twoDimArray);