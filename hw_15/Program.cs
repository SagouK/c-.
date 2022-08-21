// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = FillArray(6, -100, 100);
Console.WriteLine(String.Join(" ", array));

int uneven = sumUnevenNumbers(array);
Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях = {uneven}");

int[] FillArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

int sumUnevenNumbers(int[] finalArray)
{
    int sum = 0;
    int length = finalArray.Length;
    for (int i = 0; i < length; i++)
    {
        if (i % 2 > 0)
        {
            sum += finalArray[i];
        }
    }
    return sum;
}