
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
 
  int[,] matrix = new int[rows, columns]; 

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

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j],5}");
    }
    Console.WriteLine(" |");
  }
}

int[,] array2d = CreateMatrixRndInt(3, 3, 0, 10);
Console.WriteLine("Первая матрица:");
PrintMatrix(array2d);


Console.WriteLine();


int[,] CreateMatrix2RndInt(int rows, int columns, int min, int max)
{
 
  int[,] matrix = new int[rows, columns]; 

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

void PrintMatrix2(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j],5}");
    }
    Console.WriteLine(" |");
  }
}

int[,] array2d2 = CreateMatrix2RndInt(3, 3, 0, 9);
Console.WriteLine("Вторая матрица:");
PrintMatrix2(array2d2);



// не знаю что дальше..
void MultiplyMatrix(int[,] array2d, int[,] array2d2, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < array2d.GetLength(1); k++)
      {
        sum += array2d[i,k] * array2d2[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}
int[,] resultMatrix = MultiplyMatrix($"{array2d} * {array2d2} = {resultMatrix}");
MultiplyMatrix(array2d, array2d2, resultMatrix);
Console.WriteLine("Произведение первой и второй матриц:");

