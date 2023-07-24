// Задача 21:
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координаты точки А:");
// Console.Write("x:");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("y:");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("z:");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты точки B:");
// Console.Write("x:");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("y:");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("z:");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double dist = GetDistanse(x1, y1, z1, x2, y2, z2);
// double distRound = Math.Round(dist(x1, x2, y1, y2, z1, z2), 3 );
// Console.Write("Растояние между А и В: " + distRound);

// double GetDistanse(int a1, int a2, int a3 ,int b1, int b2 ,int b3);
// {
//    double firstCatet = b1 - a1;
//    double secondCatet = b2 - a2;
//    double distanse = Math.Scrt(firstCatet * firstCatet + secondCatet * secondCatet);
//    return distanse;
// }



int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");