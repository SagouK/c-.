// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int N = 0;

InputNumber(ref N);
PrintTableOfCubes(N);

static void InputNumber(ref int n)
{
    try
    {
        Console.WriteLine("Введите любое число: ");
        n = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Введены неверные данные! {exc.Message}");
        return;
    }
}
static void PrintTableOfCubes (int n)
{
    int index = 0;
    double cube = 1;
    while (index < n)
    {
        cube = Math.Pow(cube, 3);
        Console.Write($"{cube},");
        index++;
        cube = index + 1;
    }
}