// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int InitNumberA(string message, string message_error)
{
    while (true)
    {
        Console.Write(message);
        bool CorrectNumA = int.TryParse(Console.ReadLine(), out int A);
        if (CorrectNumA) return A;
        else Console.Write(message_error);
    }
}

int InitNumberB(string message, string message_error)
{
    while (true)
    {
    Console.Write(message);
    bool CorrectNumB = int.TryParse(Console.ReadLine(), out int B);
    if (CorrectNumB) return B;
    else Console.Write(message_error);
    }
}

double RaisingNumber(int A, int B)
{
    double NumberExtent = Math.Pow(A, B);
    return NumberExtent;
}

int num1 = InitNumberA("Введите число А: ", "Ошибка ввода данных!");
int num2 = InitNumberB("Введите число В: ", "Ошибка ввода данных!");
Console.WriteLine($"А = {num1}, В = {num2}");

double finalNumber = RaisingNumber(num1, num2);
Console.WriteLine($"Число {num1} в степени {num2} = {finalNumber}");