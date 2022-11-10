// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Range(int x11, int y11, int z11, int x21, int y21, int z21)
{
    int rX = x11 - x21;
    int rY = y11 - y21;
    int rZ = z11 - z21;
    double rAB = Math.Sqrt(rX * rX + rY * rY + rZ * rZ);
    return rAB;
}
double result = Range(x1,y1,z1,x2,y2,z2);
Console.Write($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {Math.Round(result, 2, MidpointRounding.ToZero)}");



