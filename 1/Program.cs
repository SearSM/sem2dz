// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int GetInfo(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine()); 
}

int n = GetInfo("Введите число: ");
int num = n / 10 % 10; // 456 / 10 = 45 % 10 = 5
System.Console.WriteLine(num);