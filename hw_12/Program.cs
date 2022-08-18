// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int InitNumber(string message, string message_error)
{
    while (true)
    {
        Console.Write(message);
        bool CorrectNum = int.TryParse(Console.ReadLine(), out int userNumber);
        if (CorrectNum) return userNumber;
        else Console.Write(message_error);
    }
}

int SumNumber(int userNumber)
{
    int sum = 0;
    while (userNumber > 0)
    {
        sum += userNumber % 10;
        userNumber /= 10;
    }
    return sum;
}


int num = InitNumber("Введите любое число: ", "Ошибка ввода данных!");
Console.WriteLine($"Вы ввели число: {num}");

int finalNum = SumNumber(num);
Console.WriteLine($"Сумма цифр числа {num} = {finalNum}");
