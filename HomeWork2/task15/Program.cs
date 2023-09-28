// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите день недели");
int Day = Convert.ToInt32(Console.ReadLine());
if (Day >= 1 && Day <=7) 
{
	if (Day >= 6) 
    {
		Console.Write("Выходной! Ура!");
	} 
    else 
    {
		Console.Write("Работаем дальше...");
	}
} 
else 
{
	Console.Write("Такого дня недели не существует!!!!!");
}