// HOMEWORK 4

Console.Clear();
Console.WriteLine("HOMEWORK 4" + "\n");


// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


Console.WriteLine("Задача 25.");
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int number = 1;
for (int i = 0; i < B; i++)
{
    number *= A;
}
Console.WriteLine("\n" + $"Число {A} в степени {B} - {number}." + "\n\n");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Console.WriteLine("Задача 27.");
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (num != 0)
{
    sum = num % 10 + sum;
    num = num / 10;
}
Console.WriteLine("\n" + $"Сумма цифр в числе - {sum}." + "\n\n");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


Console.WriteLine("Задача 29.");
int[] array = new int[8];
Random randomNumbers = new Random();
Console.Write("Массив из 8 элементов - [ ");
for ( int i = 0; i < 8; i++)
{
    array[i] = randomNumbers.Next(0, 99); // Ограничил от 0 до 99
    Console.Write(array[i] + " ");
}
Console.Write("]." + "\n\n");