// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.




Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, -10, 10);

try
{
Console.WriteLine("Введите номер строки: ");
int positionRow = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите номер столбца: ");
int positionColumn = int.Parse(Console.ReadLine() ?? "");
}
catch(Exception exc)
{
    Console.Write($"Ошибка ввода данных! {exc.Message}");
}
int positionValue = ReturnValue(array, positionRow, positionColumn);
Console.Write(positionValue);

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

int ReturnValue(int[,] finalArray, int rowPos, int columnPos, int size)
{
    int[] box = new int[size];
    for (int i = 0; i < finalArray.GetLength(0); i++)
    {
        for (int j = 0; j < finalArray.GetLength(1); j++)
        {
            if (finalArray[rowPos, columnPos] == finalArray[i,j])
            {
                return finalArray[rowPos, columnPos];
            }
        }
    }
    Console.WriteLine("Такого числа в массиве нет :С"); 
    return rowPos & columnPos;
}
