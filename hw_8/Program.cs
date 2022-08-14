// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Палиндро́м, пе́ревертень — число, буквосочетание, слово или текст, одинаково читающееся в обоих направлениях. 

int Number = 0;
InputNumber(ref Number);
CheckNumber(Number);
static void InputNumber(ref int number)
{
    try
    {
        Console.WriteLine("Введите пятизначное число: ");
        number = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}
static void CheckNumber(int number)
{
    int a1 = number / 10000;
    int a5 = number % 10;
    int a2 = (number % 10000) / 1000;
    int a4 = (number % 100) / 10;

    if (number >= 10000)
    {
        if (a1 == a5 && a2 == a4)
        {   
            Console.WriteLine($"Это палиндром: {number}");
        }
        else
        {
            Console.WriteLine($"Это не палиндром: {number}");
        }
    }
    else
    {
        Console.WriteLine("Это не пятизночное число, пожалуйста, введите пятизначное!");
    }

}