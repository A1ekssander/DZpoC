// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите первое число(М):");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число(N):");
int number2 = Convert.ToInt32(Console.ReadLine());


void NaturalNumbersRange(int m, int n)
{
    if (m > n)
    {
        Console.Write($" {m}");
        NaturalNumbersRange(m - 1, n);
    }
    else if (m < n)
    {
        Console.Write($" {m}");
        NaturalNumbersRange(m + 1, n);
    }
    else Console.Write($" {m}");
}

if (number1 < 0 || number2 < 0) //здесь проверяем чтобы числа были положительные и чтобы программа не работала с отрицательными числами!
{
    Console.WriteLine("Неправильный ввод(отрицательное число)");
    return;
}


NaturalNumbersRange(number1, number2);



int number = SumNumbers;

int SumNumbers(int number)
{
    int sum = 0;
    for (int i = 1; i < number; i++)
    {
        sum +=i;
    }
    return sum;
}
int SumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел в промежутке от {number1} до {number2} = {SumNumbers}");

