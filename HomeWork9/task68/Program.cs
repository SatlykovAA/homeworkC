// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
// m = 3, n = 2 -> A(m,n) = 9


Console.Write("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter m: ");
int m = Convert.ToInt32(Console.ReadLine());

int Func(int m,int n)
{
     if (m == 0) return n + 1;
     if (m > 0 && n == 0) return Func(m - 1, 1);
     else return Func(m - 1, Func(m, n - 1));
}

Console.Write($"m = {m}, n = {n} - > A(m,n) = {Func(m, n)} ");