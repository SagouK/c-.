// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

double[,] array = GetArray(3, 4, -10, 10);
double[] num = Average(array, 3, 4);
Console.WriteLine("Среднее арифметическое элементов в каждом столбце = ");
Console.Write(String.Join("; ", num));

double[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] arr = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i,j] = new Random().Next(minValue, maxValue + 1);
            Console.Write($"{arr[i,j]}\t");
        }
        Console.WriteLine(); 
    }   
    return arr;
}

double[] Average(double[,] myArray, int row, int column)
{
    double[] finalArray = new double[column];
    double sum = 0;
    double meanNum = 0;
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        for (int i = 0; i < myArray.GetLength(0); i++)
        {  
            sum += myArray[i,j];
            meanNum = sum/row;
            finalArray[j] = Math.Round(meanNum, 2);
        }
        sum = 0;
    }
    return finalArray;
}