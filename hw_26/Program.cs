// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.WriteLine("Введите число начала промежутка: ");
int m = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите число конца промежутка: ");
int n = int.Parse(Console.ReadLine() ?? "");

Console.Write(GetNumbers(m,n));

int GetNumbers(int start, int end)
{
    if(start == end) return start;
    Console.Write(start);
    Console.Write(",");
    return GetNumbers(start + 1, end);
}