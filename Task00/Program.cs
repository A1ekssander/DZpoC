// Задача 0. Программа, которая на вход принимает число и выдаёт его квадрат.
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine("Квадрат данного числа");
Console.WriteLine(square);
