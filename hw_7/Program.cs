// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

int number = new Random().Next(1, 8);

Console.WriteLine($"Случайная цифра = {number}");

if (number > 5) 
{
    Console.WriteLine("Выходной!");
}
else
{
    Console.WriteLine("Не выходной :(");
}