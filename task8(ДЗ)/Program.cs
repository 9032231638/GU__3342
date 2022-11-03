// Напишите программу, которая 
// 1. на вход принимает число (N),
// 2. а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до n");
while (k <= n)
{
    if (i % 2 == 0)
    {
        Console.Write(i + "n");
    }
    i++;
}

