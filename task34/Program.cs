//  Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
CreateArrayRndNum(num);
Console.WriteLine("Вот наш массив: ");
PrintArray(num);
int count = 0;

for (int x = 0; x < num.Length; x++)
if (num[x] % 2 == 0)
count++;

Console.WriteLine($"всего {num.Length} чисел, {count} из них чётные");

void CreateArrayRndNum(int[] num)
{
    for(int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] num)
{
    Console.Write("[ ");
    for(int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
