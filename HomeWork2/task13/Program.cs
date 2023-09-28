// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число:");
int Value = Convert.ToInt32(Console.ReadLine());
int L = Value.ToString().Length;
if (L >= 3) 
{
	while (Value > 999)
	{
		Value = Value / 10;
	}
	int result = Value % 10;
	Console.WriteLine("Третья цифра = " + result);
} 
else 
{
	Console.WriteLine("Нет третьей цифры");
}