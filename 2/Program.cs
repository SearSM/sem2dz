// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int GetInfo(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

int number = GetInfo("Введите число: ");

while (number > 999)
{
    number = number / 10;
}

if (number / 100 == 0)
{
    System.Console.WriteLine($"В числе {number} -> третьей цифры нет");
}
else
{
    System.Console.WriteLine(number % 10);
}