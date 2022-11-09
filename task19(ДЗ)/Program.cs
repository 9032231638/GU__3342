// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number => 10000 && numder <= 99999)
{
    int num1 = number / 10000;
    int num2 = numder / 1000 % 10;
    int num4 = numder / 10 % 10;
    int num5 = numder % 10;

    if (num1 == num5 && num2 == num4) Console.WriteLine("Да, это палиндром");
    else Console.WriteLine("Нет, это не палиндром");
}
else Console.WriteLine("Введено не пятизначное число");


