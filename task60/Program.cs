// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int d1 = InputInt("Введите размерность 1: ");
int d2 = InputInt("Введите размерность 2: ");
int d3 = InputInt("Введите размерность 3: ");
int countNums = 89;

if (d1 * d2 * d3 > countNums)
{
    Console.Write("Массив не подходит");
    return;
}

int[,,] resNums = Create3DMass(d1, d2, d3);

for (int i = 0; i < resNums.GetLength(0); i++)
{
    for (int j = 0; j < resNums.GetLength(1); j++)
    {
        for (int k = 0; k < resNums.GetLength(2); k++)
        {
            Console.WriteLine($"[{i},{j},{k}] - {resNums[i, j, k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,,] Create3DMass(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] val = new int[countNums];
    int num 
    = 10;
    for (int i = 0; i < val.Length; i++)
        val[i] = num
        ++;
        
    for (int i = 0; i < val.Length; i++)
    {
        int random = new Random().Next(0, val.Length);
        int temp = val[i];
        val[i] = val[random];
        val[random] = temp;
    }

    int valIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = val[valIndex++];
            }
        }
    }
    return array;
}


int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
