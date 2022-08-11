// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

double number = new Random().Next(1, 1000);

Console.WriteLine($"Случайное число = {number}");
double x = number / 100;
if (x > 1)
{
    double a = number % 10;
    Console.WriteLine($"Третья цифра числа = {a}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
