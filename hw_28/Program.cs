// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.

Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите n ");
int n = int.Parse(Console.ReadLine() ?? "");

Console.Write($"Результат функции А({m},{n}) = {GetAckermannfunction(m,n)}");

int GetAckermannfunction(int x, int y)
{
    if (x == 0) return y + 1;
    else
    if ((y == 0) && (n != 0)) return GetAckermannfunction(x-1,1);
    else
    return GetAckermannfunction(x-1, (GetAckermannfunction(x, y - 1)));
}