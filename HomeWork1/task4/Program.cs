// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int max = 0;
Console.WriteLine("Ведите число 1");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите число 2");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите число 3");
int c = int.Parse(Console.ReadLine());
if(a > max)
{
    max = a;
}

if(b > max)
{
    max = b;
}

if(c > max)
{
    max = c;
}
 
Console.WriteLine("max = " + max);