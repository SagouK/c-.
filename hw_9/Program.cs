// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

double X1 = 0; double Y1 = 0; double Z1 = 0; double X2 = 0; double Y2 = 0; double Z2 = 0; 

InputCoords(ref X1, ref Y1, ref Z1, ref X2, ref Y2, ref Z2);
CountAndPrintDistance(X1, Y1, Z1, X2, Y2, Z2);


static void InputCoords(ref double x1, ref double y1, ref double z1, ref double x2, ref double y2, ref double z2)
{
    try
    {
        Console.WriteLine("Введите X1: ");
        x1 = int.Parse(Console.ReadLine() ?? "");

        Console.WriteLine("Введите Y1: ");
        y1 = int.Parse(Console.ReadLine() ?? "");

        Console.WriteLine("Введите Z1: ");
        z1 = int.Parse(Console.ReadLine() ?? "");

         Console.WriteLine("Введите X2: ");
        x2 = int.Parse(Console.ReadLine() ?? "");

        Console.WriteLine("Введите Y2: ");
        y2 = int.Parse(Console.ReadLine() ?? "");

        Console.WriteLine("Введите Z2: ");
        z2 = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}
static void CountAndPrintDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
    Console.WriteLine(distance);
}