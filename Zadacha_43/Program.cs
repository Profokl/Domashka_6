// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение k1:");
bool isNumber1 = double.TryParse(Console.ReadLine(), out double a);
if (!isNumber1)
{
    Console.Write("Число введено не верно");
    return;
}
Console.WriteLine("Введите значение b1:");
bool isNumber2 = double.TryParse(Console.ReadLine(), out double b);
if (!isNumber2)
{
    Console.Write("Число введено не верно");
    return;
}
Console.WriteLine("Введите значение k2:");
bool isNumber3 = double.TryParse(Console.ReadLine(), out double c);
if (!isNumber3)
{
    Console.Write("Число введено не верно");
    return;
}
Console.WriteLine("Введите значение b2:");
bool isNumber4 = double.TryParse(Console.ReadLine(), out double d);
if (!isNumber4)
{
    Console.Write("Число введено не верно");
    return;
}

if (a - c == 0)
{
    Console.WriteLine("Прямые не пересекаются");
    return;
}

double FindX(double j, double k, double m, double n)
{
    double x = (k - n) / (j - m);
    return x;
}

double x = FindX(a, b, c, d);

double FindY(double m, double n)
{
    double y = m * FindX(a, b, c, d) - n;
    return y;
}

double y = FindY(c, d);
Console.WriteLine($"Точка пересечения прямых находится по следующим координатам: {x}:{y}");