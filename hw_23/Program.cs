// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int rows = 0; int columns = 0;

GetRowsColumns(ref rows, ref columns);


if (rows!=columns) 
{
    int[,] array = GetArray(rows, columns, -10, 10);

    int minSum = GetSumFirstRow(array);
   
    MinSumElements(array, minSum);
}
else Console.WriteLine("Неверное количество строк и стобцов!");



static void GetRowsColumns(ref int m, ref int n)
{
try
{
    Console.WriteLine("Введите количество строк двумерного массива: ");
    m = int.Parse(Console.ReadLine() ?? "");

    Console.WriteLine("Введите количество столбцов двумерного массива: ");
    n = int.Parse(Console.ReadLine() ?? "");
}
catch(Exception exc)
{
    Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
    return;
}
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] myArray = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            {
                myArray[i,j] = new Random().Next(minValue, maxValue + 1);
                Console.Write($"{myArray[i,j]}\t");
            }
        }
        Console.WriteLine();
    }
    return myArray;
}

int GetSumFirstRow(int[,] secArray)
{
    int mSum = 0;
    for (int j = 0; j < secArray.GetLength(1); j++)
    {
        mSum += secArray[0,j];
    }
    return mSum;
}

void MinSumElements(int[,] finalArray, int minAmount)
{
    int minRow = 0;
    int finalSum = 0;
    int sumElements = 0;
    for (int i = 1; i < finalArray.GetLength(0); i++)
    {
        for (int j = 0; j < finalArray.GetLength(1); j++)
        {
            sumElements += finalArray[i,j];
        }
        finalSum = sumElements;
        if (finalSum < minAmount)
        {
            minAmount = finalSum;
            minRow = i;
        }
        sumElements = 0;
    }
    Console.WriteLine($"{minRow} строка содержит минимальную сумму элементов: {minAmount}");
}
 
    