// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int rowsA = 0; int columnsA = 0;
int rowsB = 0; int columnsB = 0;

GetRowsColumns(ref rowsA, ref columnsA, "Введите количество строк матрицы A: ", "Введите количество столбцов матрицы A: ");
GetRowsColumns(ref rowsB, ref columnsB, "Введите количество строк матрицы В: ", "Введите количество столбцов матрицы В: ");

int[,] matrixC = new int[rowsA,columnsB];

if (columnsA == rowsB)
{
    int[,] matrixA = GetArray(rowsA, columnsA, -10, 10);
    Console.WriteLine();
    int[,] matrixB = GetArray(rowsB, columnsB, -10, 10);
    Console.WriteLine();
    

    GetProductAB(matrixA, matrixB, matrixC, rowsA, columnsB);
    PrintArrayC(matrixC);
}
else Console.WriteLine("Неверное количество строк и стобцов! Произведение двух матриц АВ имеет смысл только в том случае, когда число столбцов матрицы А совпадает с числом строк матрицы В ");

static void GetRowsColumns(ref int m, ref int n, string messageRow, string messageColumns)
{
    try
    {
        Console.WriteLine(messageRow);
        m = int.Parse(Console.ReadLine() ?? "");

        Console.WriteLine(messageColumns);
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

void GetProductAB(int[,] arrayA, int[,] arrayB, int[,] arrayC, int rowA, int columnB)
{
    //int[,] arrayC = new int[i,j];
    
    for (int i = 0; i < arrayC.GetLength(0); i++)
    {
        for (int j = 0; j < arrayC.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                sum = sum + (arrayA[i,k] * arrayB[k,j]);
            }
            arrayC[i,j] = sum;
        }
    }
}

void PrintArrayC(int[,] finalArray)
{
    Console.WriteLine("Произведение матрицы АВ");
    for (int i = 0; i < finalArray.GetLength(0); i++)
    {
        for (int j = 0; j < finalArray.GetLength(1); j++)
        {
            Console.Write($"{finalArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}