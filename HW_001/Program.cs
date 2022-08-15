// HOMEWORK 1

//  Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.WriteLine("Задача 2.");
Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
if (numberOne > numberTwo)
{
    Console.WriteLine("Максимальное число: " + numberOne);
    Console.WriteLine("Минимальное число: " + numberTwo);
}
else
{
    Console.WriteLine("Максимальное число: " + numberTwo);
    Console.WriteLine("Минимальное число: " + numberOne);
}



Console.WriteLine(" ");
// Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Задача 4.");
Console.Write("Введите три числа: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int max = firstNumber;
if (secondNumber > max || secondNumber == max)
{
    max = secondNumber;
    if (thirdNumber > max || thirdNumber == max)
    {
        max = thirdNumber;
    }
}
else if (thirdNumber > max || thirdNumber == max)
{
    max = thirdNumber;
}
Console.WriteLine("Максимальное число: " + max);



Console.WriteLine(" ");
// Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Задача 6.");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("Да, число чётное.");
}
else
{
    Console.WriteLine("Нет, число нечётное.");
}



Console.WriteLine(" ");
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Задача 8.");
Console.Write("Введите число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
int count = 0;
if (anyNumber > 1)
{
    count = 2;
    while (count <= anyNumber)
    {
        Console.Write(count + ", ");
        count += 2;
    }
}
else if (anyNumber == 0)
{
    Console.Write(anyNumber + " ");
}
else
{
    count = 0;
    while (count >= anyNumber)
    {
        Console.Write(count + ", ");
        count -= 2;
    }
}




Console.WriteLine(" ");
// ДОПОЛНИТЕЛЬНЫЕ ЗАДАЧИ



// Задача 5: Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Дополнительная задача №5.");
Console.Write("Введите число: ");
int someNumber = Convert.ToInt32(Console.ReadLine());
int i = (-someNumber) + 1;
Console.Write(-someNumber);
while ((-someNumber) <= i && i <= someNumber)
{
    Console.Write(", " + i);
    i += 1;
}



Console.WriteLine(" ");
// Задача 7: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Дополнительная задача №7.");
Console.Write("Введите число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Последняя цифра числа: " + threeDigitNumber % 10);
