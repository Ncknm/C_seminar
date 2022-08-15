// HOMEWORK 2

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.Clear();
Console.WriteLine("Задача 10.");
Console.Write("Введите трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
if (stringNumber.Length < 2)
{
    Console.WriteLine("В числе нет второй цифры!");
}
else 
{
    Console.WriteLine("Вторая цифра этого числа: " + stringNumber[1]);
}

Console.WriteLine(" ");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.



Console.WriteLine("Задача 13.");
Console.Write("Введите число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("Третья цифра числа: " + anyNumberText[2]);
}
else {
  Console.WriteLine("Третьей цифры нет.");
}


Console.WriteLine(" ");

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.



Console.WriteLine("Задача 15.");
Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("Является выходным? Да.");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Неверное число!");
  }
  else Console.WriteLine("Является выходным? Нет.");
}
CheckingTheDayOfTheWeek(dayNumber);