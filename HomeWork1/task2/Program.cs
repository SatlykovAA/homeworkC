// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int max = 0;
int min = 0;
Console.WriteLine("Ведите число 1");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите число 2");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    max = a;
    min = b;
    Console.WriteLine("max = " + max + " и " + "min = " + min);
}
else
if (a < b)
{
    max = b;
    min = a;
    Console.WriteLine("max = " + max + " и " + "min = " + min);
}
else
{
    a = b;
    Console.WriteLine("Числа равны");
}
