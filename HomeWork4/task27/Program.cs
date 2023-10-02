// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int ReadNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);

}
int Sum(int A)
{
    int res = 0;
    while (A >0)
    {
        res = res + A%10;
        A = A / 10;
    }
   return res;
  }



int A = ReadNumber("Enter A:  ");
Console.WriteLine($"Сумма цифр в числе {A} =  {Sum(A)}");



