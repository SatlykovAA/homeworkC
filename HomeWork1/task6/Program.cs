// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Ведите число ");
int a = int.Parse(Console.ReadLine());

int ost = a % 2;

if (ost == 0)
{
    Console.WriteLine("четное");
}
else
{
    Console.WriteLine("Не четное");
}