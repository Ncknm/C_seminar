// HOMEWORK 8

Console.Clear();
Console.WriteLine("HOMEWORK 8" + "\n");


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


int Prompt(string message)
{
    System.Console.Write(message);                    
    int result = Convert.ToInt32(Console.ReadLine()); 
    return result;                                    
}

int[,] FillArray(int numLine, int numColumns)         
{
    Random rand = new Random();
    int[,] matrix = new int[numLine, numColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)  
    {
        for (int j = 0; j < matrix.GetLength(1); j++)     
        {
            matrix[i, j] = rand.Next(1, 9);    
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)  
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int [,] array = FillArray(Prompt("Введите число строк: "), Prompt("Введите число столбцов: "));
Console.WriteLine("\nЗаданный массив: ");
PrintArray(array);

for (var i = 0; i < array.GetLength(0); i++)
    for (var j = 0; j < array.GetLength(1); j++)
        for (var k = 0; k < array.GetLength(1); k++)
        {
            if (array[i, j] >= array[i, k])
            {
                int temp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = temp;
            }
        }
Console.WriteLine("\nУпорядоченный массив: ");
PrintArray(array);