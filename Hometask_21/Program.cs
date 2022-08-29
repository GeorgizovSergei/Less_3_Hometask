// Задача 21.
// Напишите программу которая 
// 1. принимает на вход координаты двух точек и 
// 2. находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(int xc1, int yc1, int zc1, int xc2, int yc2, int zc2)
{
     return Math.Sqrt((xc2 - xc1) * (xc2 - xc1) + (yc2 - yc1) * (yc2 - yc1) + (zc2 - zc1) * (zc2 - zc1));
    
}

Console.WriteLine("Введите координаты точки A: ");
    Console.Write("X: ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Y: ");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Z: ");
    int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
    Console.Write("X: ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Y: ");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Z: ");
    int z2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine("Растояние между точками равно {0: #.##}", result);
