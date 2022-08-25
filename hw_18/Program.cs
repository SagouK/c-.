// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

double[] array = GetValuesStraights(4);
double pointX = GetPointIntersectionX(array);
double pointY = GetPointIntersectionY(array, pointX);
Console.WriteLine($"Координаты точки пересечения двух прямых = {pointX}, {pointY}");

double[] GetValuesStraights(int size)
{
    double[] arr = new double[size];
    try
    {
    Console.WriteLine("Введите координату b1: ");
    arr[0] = double.Parse(Console.ReadLine() ?? "");     
    
    Console.WriteLine("Введите координату k1: ");
    arr[1] = double.Parse(Console.ReadLine() ?? "");   

    Console.WriteLine("Введите координату b2: ");
    arr[2] = double.Parse(Console.ReadLine() ?? "");   

    Console.WriteLine("Введите координату k2: ");
    arr[3] = double.Parse(Console.ReadLine() ?? "");   
    }
    catch(Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
    }
    return arr;
}


double GetPointIntersectionX(double[] finalArray)
{
    double x = (finalArray[2] - finalArray[0]) / (finalArray[1] - finalArray[3]);
    return x;
}

double GetPointIntersectionY(double[] finalArray, double x)
{
    double y = (finalArray[3] * x) + finalArray[2];
    return y;
}



