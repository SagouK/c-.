// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

int[] array = FillArray(5, 100, 1000);
Console.WriteLine(String.Join(" ", array));

int even = GetCountEvenNumbers(array);
Console.WriteLine($"Количество четных чисел в массиве = {even}");

int[] FillArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

int GetCountEvenNumbers(int[] finalArray)
{
    int length = finalArray.Length;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (finalArray[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}
