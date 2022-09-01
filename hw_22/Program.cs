// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.


Console.WriteLine("Введите количество строк двумерного массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите количество столбцов двумерного массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, -10, 10);


int[,] sortArr = SortArrayDescending(array);

Console.WriteLine();

PrintSortArray(sortArr);

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    Console.WriteLine("Задан массив: ");
    int[,] arr = new int[rows, columns];
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

int[,] SortArrayDescending(int[,] secArray)
{
    int box;
    for (int i = 0; i < secArray.GetLength(0); i++)
    {
        for (int j = 0; j < secArray.GetLength(1)-1; j++)
        {
            for (int k = secArray.GetLength(1)-1; k > j; k--)
            {
                if (secArray[i,j] < secArray[i, k])
                {
                    box = secArray[i,j];
                    secArray[i,j] = secArray[i, k];
                    secArray[i, k] = box;
                }
            }
        }
    }
    return secArray;
}

void PrintSortArray(int[,] finalArray)
{
    Console.WriteLine("Массив, сортированный по убыванию: ");
    for (int i = 0; i < finalArray.GetLength(0); i++)
    {
        for (int j = 0; j < finalArray.GetLength(1); j++)
        {
            Console.Write($"{finalArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}