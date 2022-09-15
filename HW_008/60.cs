// HOMEWORK 8

Console.Clear();
Console.WriteLine("HOMEWORK 8" + "\n");


// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


Console.WriteLine("\n" + "Задача 60." + "\n");
int line = 2;
int columns = 2;
int cube =2;
int antiRepeat=1;
int startTwoNum=10;
Random rand = new Random();
Console.WriteLine("Трехмерный массив: ");
int[,,] matrix1 = new int[line, columns, cube];
for (int i = 0; i < matrix1.GetLength(0); i++)  
{
    for (int j = 0; j < matrix1.GetLength(1); j++) 
    {
        for (int k = 0; k < matrix1.GetLength(2); k++)   
        {
            matrix1[i, j, k] = startTwoNum + antiRepeat;
            antiRepeat++;
            Console.Write($"{matrix1[i, j, k]} ({j},{k},{i})\t");   
        }
        Console.WriteLine();
    }
}