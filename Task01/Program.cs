﻿// является ли первое число(a) квадратом второго(b)?

        Console.WriteLine("Введите первое число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int b = Convert.ToInt32(Console.ReadLine());

        if (a == b * b)
        {
            Console.Write("Да");
        }
        else
        {
            Console.Write("Нет");
        }
        