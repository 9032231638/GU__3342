// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.

// N = 5
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
void Cube(int num)
{
    if (num > 0)
    {
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine($"{i} {i * i * i}");
        }
    }
    else
    {
        Console.WriteLine("Введите число больше 0");
    }
}

Cube(n);
