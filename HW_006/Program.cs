// HOMEWORK 6

Console.Clear();
Console.WriteLine("HOMEWORK 6" + "\n");


// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.WriteLine("Задача 41.");
Console.Write($"Введите число М (количество чисел): ");
int size = Convert.ToInt32(Console.ReadLine());
int[] NumbersArray = new int[size];

void InputNumbers(int size) 
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1}-е число: ");
        NumbersArray[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int Comparison(int[] NumbersArray)
{
  int count = 0;
  for (int i = 0; i < NumbersArray.Length; i++)
  {
    if(NumbersArray[i] > 0) 
        {
            count += 1; 
        }
  }
  return count;
}

InputNumbers(size);
Console.WriteLine("\n" + $"Колличество чисел больше нуля - {Comparison(NumbersArray)}." + "\n\n");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


Console.WriteLine("Задача 41.");

Console.Write("Введите число B1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число K1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число K2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
if (b2 - b1 != k2 - k1)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = k1 * x + b1;
    Console.WriteLine("\n" + $"Точка пересечения прямых (х; y) = ({x}; {y})." + "\n");
}
else
{
    Console.WriteLine("\n" + "Прямые не пересекаются." + "\n\n");
}