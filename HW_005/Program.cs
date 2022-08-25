// HOMEWORK 5

// Функция для вывода рандомных чисел

int[] Random(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
Console.Clear();
Console.WriteLine("HOMEWORK 5" + "\n");



// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


Console.WriteLine("Задача 34.");
int[] arrayOne = Random(6, 100, 999);
Console.WriteLine($"Массив: [{String.Join(", ", arrayOne)}]");
int evenNumber = 0;
for (int i = 0; i < arrayOne.Length; i++)
{
    if (arrayOne[i] % 2 == 0)
    {
        evenNumber ++;
    }
}
Console.WriteLine($"Количество четных чисел в массиве - {evenNumber}." + "\n");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


Console.WriteLine("Задача 36.");
int[] arrayTwo = Random(6, 1, 99);
Console.WriteLine($"Массив: [{String.Join(", ", arrayTwo)}]");
int total = 0;
// Если мы ищем нечетные позиции, отталкиваясь от индекса, то в задаче нечетным числом считаем элемент массива, у которого индекс - нечетный.
for (int i = 1; i < arrayTwo.Length; i += 2)
{
    total = total + arrayTwo[i];
}
Console.WriteLine($"Суммa элементов, стоящих на нечётных позициях - {total}." + "\n");
// Если же мы хотим посчитать сумму нечетных чисел, отталкиваясь не от индекса, а их положения (i[0] - нечетная позиция) то в цикле достаточно поменять начальное значение переменной i с 1 на 0.



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


Console.WriteLine("Задача 38.");
int[] arrayThree = Random(6, 1, 10);
Console.WriteLine($"Массив: [{String.Join(", ", arrayThree)}]");
int min = arrayThree[0], 
    max = arrayThree[0];
for (int i = 1; i < arrayThree.Length; i++)
{
    if (arrayThree[i] > max)
    {
        max = arrayThree[i];
    }
    if (min > arrayThree[i])
    {
        min = arrayThree[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным элементов массива - {max - min}." + "\n");