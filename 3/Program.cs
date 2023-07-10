// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int GetInfo(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine()); 
}

int num = GetInfo("Введите число: ");
if (num == 6 || num == 7) System.Console.WriteLine($"{num} -> да");
else System.Console.WriteLine($"{num} -> нет");