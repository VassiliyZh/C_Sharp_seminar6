// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// x=(b2-b1)/(k1-k2), y=(k2*b1-k1*b2)/(k2-k1)

double InputNumber(string message)

{
    System.Console.WriteLine(message);
    double number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double PointIntersectionX(double k1, double k2, double b1, double b2)
{
    return (b2-b1)/(k1-k2);    
}
double PointIntersectionY(double k1, double k2, double b1, double b2)
{
    return (k2*b1-k1*b2)/(k2-k1);    
}

double k1 = InputNumber("Введите число K1: ");
double k2 = InputNumber("Введите число K2: ");
double b1 = InputNumber("Введите число B1: ");
double b2 = InputNumber("Введите число B2: ");

System.Console.WriteLine (PointIntersectionX(k1, k2, b1, b2));

System.Console.WriteLine (PointIntersectionY(k1, k2, b1, b2));
