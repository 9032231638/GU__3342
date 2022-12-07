// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("введите количество строк");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] num = new double[linesVol, columnsVol];
FillArrayRndNum(num);
PrintArray(num);

void FillArrayRndNum(double[,] array)
{
 for (int m = 0; m < array.GetLength(0); m++)
    {
     for (int n = 0; n < array.GetLength(1); n++)
        {
          array[m, n] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
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
