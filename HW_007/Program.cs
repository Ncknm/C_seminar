// HOMEWORK 7

Console.Clear();
Console.WriteLine("HOMEWORK 7" + "\n");
Random chance = new Random();
Console.WriteLine("Для построения двумерного массива, введите его размеры.");
Console.Write("Количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());


// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


Console.WriteLine("\n" + "Задача 47." + "\n");
double[,] arrayOne = new double[row, column];
for (int i = 0; i < arrayOne.GetLength(0); i++)
{
    for (int j = 0; j < arrayOne.GetLength(1); j++)
    {
        arrayOne[i,j] = chance.NextDouble() * 20 - 10;
        Console.Write("{0,6:F1}", arrayOne[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine("\n" + "Нажмите любую клавишу для продолжения...");
Console.ReadKey();
Console.Clear();
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


Console.WriteLine("Задача 50." + "\n");
int[,] arrayTwo = new int[row, column];
int counterLine = 0, counterColomn = 0;
for (int i = 0; i < arrayTwo.GetLength(0); i++)
{
    for (int j = 0; j < arrayTwo.GetLength(1); j++)
    {
        arrayTwo[i,j] = chance.Next(1, 9);
        Console.Write($"{arrayTwo[i, j]}\t");
        counterColomn++;
    }
    Console.WriteLine();
    counterLine++;
}
Console.Write("\n" + "Введите номер строки: ");
int rowNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int colNum = Convert.ToInt32(Console.ReadLine());
if (colNum <= counterColomn && rowNum <= counterLine)
{
    Console.WriteLine("\n" + $"Значение элемента: {arrayTwo[rowNum - 1, colNum - 1]}" + "\n\n");
}
else
{
    Console.Write("\n" + "Такого элемента нет." + "\n\n");
}
Console.WriteLine("\n" + "Нажмите любую клавишу для продолжения...");
Console.ReadKey();
Console.Clear();


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


Console.WriteLine("Задача 52." + "\n");
int[,] arrayThree = new int[row, column];
double numLine = 0;
for (int i = 0; i < arrayThree.GetLength(0); i++)
{
    for (int j = 0; j < arrayThree.GetLength(1); j++)
    {
        arrayThree[i, j] = chance.Next(1, 9);
        Console.Write("{0,6:F1}",$"{arrayThree[i, j]}");
    }
    Console.WriteLine();
    numLine++;
}
Console.WriteLine("\n" + "Среднее арифметическое каждого столбца: " + "\n");
int sum = 0;
for (int j = 0; j < arrayThree.GetLength(1); j++)
{
    for (int i = 0; i < arrayThree.GetLength(0); i++)
    {
        sum = sum + arrayThree[i, j];
    }
    Console.Write("{0,6:F1}", sum / numLine );
    sum = 0;
}
Console.WriteLine("\n\n");