// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число начала промежутка: ");
int m = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите число конца промежутка: ");
int n = int.Parse(Console.ReadLine() ?? "");

Console.Write($"Сумма натуральных элементов от {m} до {n} = {GetNumbers(m,n)}");

int GetNumbers(int start, int end)
{   
    int sum = 0;
    sum += start;
    if(start == end) return start;
    else
    return start + GetNumbers(start+1, end);
}
