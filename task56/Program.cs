// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.



Console.WriteLine("введите массив");
int massVol = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[massVol, massVol];
FillArrayRndNum(num);
PrintArray(num);
int xsum = Int32.MaxValue;
int x = 0;

for (int i = 0; i < num.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < num.GetLength(1); j++)
    {
        sum = sum + num[i, j];        
    }
    if (sum < xsum)
    {
        xsum = sum;
        x++;
    }
}

Console.WriteLine("Нужная строка: " + (x) + ", сумма в строке: " + (xsum));

void FillArrayRndNum(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
