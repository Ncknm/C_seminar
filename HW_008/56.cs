// HOMEWORK 8

Console.Clear();
Console.WriteLine("HOMEWORK 8" + "\n");


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


Console.WriteLine("\n" + "Задача 56." + "\n");
Console.Write("Введите количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int sum = 0;
Random rand1 = new Random();
int[,] matrix1 = new int[line, columns];
Random rand2 = new Random();
int[] matrix2 = new int[line];
Console.WriteLine("\nВаш массив: ");
for (int i = 0; i < matrix1.GetLength(0); i++)  
{
    for (int j = 0; j < matrix1.GetLength(1); j++)     
    {
        matrix1[i, j] = rand1.Next(1, 9);
        sum = sum + matrix1[i,j];
        Console.Write($"{matrix1[i, j]}\t");   
    }
    matrix2[i] = sum;
    Console.WriteLine();
    sum = 0;
}

Console.WriteLine();
int minLine = matrix2[0];
int minSum = 1;
for (int k = 1; k < line; k++)
{
    if (matrix2[k]<minLine)
    {
        minLine = matrix2[k];
        minSum = k+1;
    }
}
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minSum}");