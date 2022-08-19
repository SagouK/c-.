// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray(int[] myArray)
{
    int length = myArray.Length;
    int index = 0;
    while (index < length)
    {
        Console.WriteLine("Введите элемент массива: ");
        myArray[index] = int.Parse(Console.ReadLine() ?? "");
        index++;
    }
}

void PrintArray(int[] myArray)
{
    int count = 0;
    int sameLength = myArray.Length;
    while (count < sameLength)
    {
        Console.Write(myArray[count]);
        Console.Write(" ");
        count++;
    }
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);

