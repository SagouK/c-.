// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите любое целое число: ");

string? N = Console.ReadLine();

int number;

if (int.TryParse(N, out number))
{
    int i = 0;
    while (i < number-1)
    {
        i+=2;
        Console.Write(i);
        Console.Write(",");
    }
}
else
{
    Console.Write("Ошибка ввода!");
}
