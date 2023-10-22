// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Enter N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter M: ");
int M = Convert.ToInt32(Console.ReadLine());

int Summa(int m, int n)
{
  if (m>n)
  return 0;
  else return m + Summa(m + 1, n);
}
Console.WriteLine(Summa(M, N));
