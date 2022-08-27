// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

GetArray(3, 4);
//Console.Write($"{array[rows, columns]}");

void GetArray(int rows, int columns)
{
    double[,] arr = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i,j] = new Random().Next(-10, 10);
            Console.Write($"{arr[i, j]} ");
        } 
    Console.WriteLine();
    }   
}