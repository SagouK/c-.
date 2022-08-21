// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

double[] array = FillArray(5, -100, 100);
Console.WriteLine(String.Join(",", array));

double difference = diffMaxMin(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {difference}");

double[] FillArray(int size, int min, int max)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

double diffMaxMin(double[] finalArray)
{
    double min = finalArray[0];
    double max = finalArray[0];
    double diff = 0;
    int length = finalArray.Length;
    for (int i = 0; i < length; i++)
    {
        if (min > finalArray[i])
        {
            min = finalArray[i];
        }
        else if (max < finalArray[i])
        {
            max = finalArray[i];
        }
    }
    diff = max - min;
    return diff;
}