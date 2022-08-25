// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

int[] array = InputUserNumbers(5);
Console.WriteLine(string.Join(",", array));

int count = CountNumbersAboveZero(array);
Console.WriteLine($"Количество чисел больше 0 = {count}");

int[] InputUserNumbers(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        try
        {
            Console.WriteLine("Введите число: ");
            arr[i] = int.Parse(Console.ReadLine() ?? "");
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        }
    }
    return arr;
}

int CountNumbersAboveZero(int[] finalArray)
{
    int countNum = 0;
    int length = finalArray.Length;
    for (int i = 0; i < length; i++)
    {
        if (finalArray[i] > 0)
        {
            countNum += 1;
        }
    }
    return countNum;
}