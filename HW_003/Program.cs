// HOMEWORK 3

// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


Console.Clear();
Console.WriteLine("Задача 19.");
Console.Write("Введите пятизначное число: ");
string stringNumber = Console.ReadLine();
void CheckingNumber(string stringNumber)
{
    if (stringNumber[0] == stringNumber[4] || stringNumber[1] == stringNumber[3])
    {
        Console.WriteLine($"Число {stringNumber} является палиндром.");
    }
    else Console.WriteLine($"Число {stringNumber} не является палиндром.");
}
if (stringNumber!.Length == 5)
{
    CheckingNumber(stringNumber);
}
else Console.WriteLine($"Введите пятизачное число");
Console.WriteLine("\n");


// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.



Console.WriteLine("Задача 21.");
Console.WriteLine("Введите поочередно координаты первой точки: ");
int x1 = int.Parse(Console.ReadLine() ?? "0");
int y1 = int.Parse(Console.ReadLine() ?? "0");
int z1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите поочередно координаты второй точки: ");
int x2 = int.Parse(Console.ReadLine() ?? "0");
int y2 = int.Parse(Console.ReadLine() ?? "0");
int z2 = int.Parse(Console.ReadLine() ?? "0");
double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine($"Длина отрезка  {d:f2}");
Console.WriteLine("\n");


// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Задача 23.");
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()), index = 1;
if (number > 0)
{
    while (index <= number)
    {
        Console.Write(Math.Pow(index, 3) + " ");
        index += 1;
    }
}
else
{
    while (index >= number)
    {
        Console.Write(Math.Pow(index, 3) + " ");
        index -= 1;
    }
}