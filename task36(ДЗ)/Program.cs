// Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
CreateArrayRndInt(num);
Console.WriteLine("Заданный массив: ");
PrintArray(num);
int sum = 0;

for (int x = 1; x < num.Length; x+=2)
    sum = sum + num[x];

    Console.WriteLine($"всего {num.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void CreateArrayRndInt(int[] num)
{
    for(int i = 0; i < num.Length; i++)
        {
            num[i] = new Random().Next(-30,30);
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

