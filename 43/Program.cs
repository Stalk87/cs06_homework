//Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1
//y = k2 * x + b2
//значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("введи k1");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("введи b1");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("введи k2");
double k2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("введи b2");
double b2 = double.Parse(Console.ReadLine()!);

double x = 0;
double y = 0;

result(k1, b1, k2, b2);

void result(double k1, double b1, double k2, double b2)
{
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
        Console.WriteLine($"x = {x}, y = {y}");
    }
}