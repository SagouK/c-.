// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine() ?? "");


int[,] array = GetArray(rows, columns, -10, 10);


Console.WriteLine("Введите номер строки: ");
int positionRow = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите номер столбца: ");
int positionColumn = int.Parse(Console.ReadLine() ?? "");


ReturnValue(array, positionRow, positionColumn);


int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] arr = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i,j] = new Random().Next(minValue, maxValue + 1);
            Console.Write($"{arr[i, j]}\t");
        } 
    Console.WriteLine();
    }
    return arr;
}

void ReturnValue(int[,] finalArray, int rowPos, int columnPos)
{
    bool elementExist = false;
    int i = 0; int j = 0;
    for (i = 0; i < finalArray.GetLength(0); i++)
    {
        for (j = 0; j < finalArray.GetLength(1); j++)
        {
            if (rowPos == i && columnPos == j)
            {
                elementExist = true;
                Console.WriteLine($"Этот элемент существует: {finalArray[rowPos, columnPos]}");
                break;
            } 
        }
    }
    if (elementExist == false)
    {
        Console.WriteLine($"Такого элемента не существует --> [{rowPos},{columnPos}]");
    }
}
