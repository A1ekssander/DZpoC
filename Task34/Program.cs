
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] array = new int[10];
FillArray(array);
PrintArray(array);

void FillArray(int[] arr)
{
  for (int i=0; i < arr.Length; i++)
  {
     arr[i] = new Random().Next(99,1000);
  }
}

void PrintArray(int[] arr)
{
  for (int i=0; i < arr.Length; i++)
  {
    Console.Write (arr[i] + " ");
  }
}

int count = 0;
{
for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;
}
