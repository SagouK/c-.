// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");

string? a = Console.ReadLine();

Console.Write("Введите второе число: ");

string? b = Console.ReadLine();

Console.Write("Введите третье число: ");

string? c = Console.ReadLine();


int first_number;
int second_number;
int third_number;


if (int.TryParse(a, out first_number))
{
    int max = first_number;
    if (int.TryParse(b, out second_number))
    {
        if (int.TryParse(c, out third_number))
        {
            if (second_number > max)
            {
                max = second_number;
            }
            if (third_number > max)
            {
                max = third_number;
                Console.Write("Максимальное число: ");
                Console.Write(max);
            }
            else
            {
                Console.Write("Максимальное число: ");
                Console.Write(max);
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода!");
        }
    }
    else
    {
        Console.WriteLine("Ошибка ввода!");
    }
}
else
{
    Console.WriteLine("Ошибка ввода!");
}