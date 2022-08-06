// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");

string? a = Console.ReadLine();

Console.WriteLine("Введите второе число: ");

string? b = Console.ReadLine();

int first_number;
int second_number;

if (int.TryParse(a, out first_number))
{
    if (int.TryParse(b, out second_number))
    {
            if (first_number > second_number)
            {
                Console.Write("Первое число больше: ");
                Console.WriteLine(first_number);
                Console.Write("Второе число меньше: ");
                Console.WriteLine(second_number);
            }
           
            else
            {
                Console.Write("Второе число больше: ");
                Console.WriteLine(second_number);
                Console.Write("Первое число меньше: ");
                Console.WriteLine(first_number);
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