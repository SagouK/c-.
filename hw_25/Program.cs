// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();

int[,,] array = GetArray(2, 2, 2, 10, 99);


int[,,] GetArray(int x, int y, int z, int minValue, int maxValue)
{
    int[,,] arr = new int[x, y, z];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i,j,k] = new Random().Next(minValue, maxValue + 1);
                Console.Write($"{arr[i,j,k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    return arr;
}
