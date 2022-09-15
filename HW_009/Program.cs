// HOMEWORK 9

Console.Clear();
Console.WriteLine("HOMEWORK 9" + "\n");


// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.


Console.WriteLine("\n" + "Задача 64." + "\n");
int PrintNumbers(int start, int end)
{
    Console.Write($"{start} ");
    if (start == end) return start;
    return PrintNumbers(start + 1, end);
}

Console.Write("Введите M: ");
int numberM = int.Parse(Console.ReadLine()!);
Console.Write("Введите N: ");
int numberN = int.Parse(Console.ReadLine()!);
Console.WriteLine($"\nЧисла в промежутке от {numberM} до {numberN}: ");
PrintNumbers(numberM, numberN);
Console.WriteLine("\n" + "Нажмите любую клавишу для продолжения...");
Console.ReadKey();
Console.Clear();


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


Console.WriteLine("\n" + "Задача 66." + "\n");
int sum(int start, int end)
{
    if (start == end) return end;
    return end + sum(start, end - 1);
}

Console.Write("Введите M: ");
int numberM_Two = int.Parse(Console.ReadLine()!);
Console.Write("Введите N: ");
int numberN_Two = int.Parse(Console.ReadLine()!);

Console.WriteLine($"\nСумма чисел в промежутке от {numberM_Two} до {numberN_Two}: {sum(numberM_Two, numberN_Two)}");
Console.WriteLine("\n" + "Нажмите любую клавишу для продолжения...");
Console.ReadKey();
Console.Clear();


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


Console.WriteLine("\n" + "Задача 68." + "\n");
int Accerman(int m, int n)
{
    if (n == 0) return m + 1;
    if (n > 0 && m == 0) return Accerman(1, n - 1);
    return Accerman(Accerman(m - 1, n), n - 1);
}
Console.Write("Введите M: ");
int numberM_Three = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите N: ");
int numberN_Three = Convert.ToInt32(Console.ReadLine()!);
Console.Write($"\nФункция Аккермана равна: {Accerman(numberM_Three, numberN_Three)}.");