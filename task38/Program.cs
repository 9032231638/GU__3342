// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] num = new double[size];
CreateArrayRnd(num);
Console.WriteLine("Заданный массив: ");
PrintArray(num);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int x = 0; x < num.Length; x++)
{
    if (num[x] > max)
        {
            max = num[x];
        }
    if (num[x] < min)
        {
            min = num[x];
        }
}

Console.WriteLine($"Ответ = {max - min}");

void CreateArrayRnd(double[] num)
{
    for(int i = 0; i < num.Length; i++)
        {
            num[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] num)
{
    Console.Write("[ ");
    for(int i = 0; i < num.Length; i++)
        {
            Console.Write(num[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

