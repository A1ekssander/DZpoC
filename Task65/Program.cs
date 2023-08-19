
// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


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

        // Знак || означает "или"
if (number1 < 0 || number2 < 0) //здесь проверяем чтобы числа были положительные и чтобы программа не работала с отрицательными числами!
{
    Console.WriteLine("Неправильный ввод(отрицательное число)");
    return;
}

NaturalNumbersRange(number1, number2);