// Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("введите кол-во строк");
int linVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите кол-во столбцов");
int colVol = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[linVol, colVol];
FillArrayRndNum(num);
Console.WriteLine();
Console.WriteLine("Заданный массив");
PrintArray(num);

for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < num.GetLength(1) - 1; k++)
        {
            if (num[i, k] < num[i, k + 1])
            {
                int temp = 0;
                temp = num[i, k];
                num[i, k] = num[i, k + 1];
                num[i, k + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив после обработки");
PrintArray(num);

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
