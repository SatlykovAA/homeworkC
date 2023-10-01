// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введите координату х точки А:  ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y точки А:  ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z точки А:  ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату х точки B:  ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y точки B:  ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z точки B:  ");
int y3 = Convert.ToInt32(Console.ReadLine());
double result =  Math.Sqrt(Math.Pow(y1 - x1, 2) + Math.Pow(y2 - x2, 2) + Math.Pow(y3 - x3, 2));

Console.WriteLine($"Расстояние между точками = {result}");
