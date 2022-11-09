// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки");
Console.Write("X1:");
int x1 = Convert.ToUInt32(Console.ReadLine());
Console.Write("Y1:");
int y1 = Convert.ToUInt32(Console.ReadLine());
Console.Write("Z1:");
int z1= Convert.ToUInt32(Console.ReadLine());
Console.Write("X2:");
int x2 = Convert.ToUInt32(Console.ReadLine());
Console.Write("Y2:");
int y2 = Convert.ToUInt32(Console.ReadLine());
Console.Write("Z2:");
int z2 = Convert.ToUInt32(Console.ReadLine());

double len = Math.Sqrt((x2 - x1)^2 + (y2 - y1)^2 + (z2 - z1)^2);
Console.WriteLine("Длинна отрезка {len}");

