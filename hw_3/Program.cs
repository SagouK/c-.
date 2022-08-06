/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка). */

Console.Write("Введите целое число: ");

string? number = Console.ReadLine();

int this_number;

if (int.TryParse(number, out this_number))
{
    if (this_number % 2 == 0)
    {
        Console.Write("Это число четное: ");
        Console.Write(this_number);
    }
    else
    {
        Console.Write("Это число нечетное: ");
        Console.Write(this_number);
    }
}
else
{
    Console.Write("Ошибка ввода!");
}