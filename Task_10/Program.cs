// Задача 10: 
//Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число ");
int N = int.Parse(Console.ReadLine()!);
int SecondDigit;

SecondDigit=(N%100)/10;

Console.Write($"Вторая цифра числа {SecondDigit}");


