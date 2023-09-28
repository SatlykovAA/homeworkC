// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число:");

int A = Convert.ToInt32(Console.ReadLine());
int Length = A.ToString().Length;
if (Length == 3) 
    {
		int B = ( A/10 ) % 10;
		Console.WriteLine($"вторая цифра этого числа {B}");
    } 
else 
    {
		Console.WriteLine("ERROR!!!!");
	}
    