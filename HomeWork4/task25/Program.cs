// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int ReadNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);

}
int Exponent(int A, int B)
{
  int result = 1;
  for(int i=1; i <= B; i++)
  {
    result = result * A;
  }
   return result;
}

int A = ReadNumber("Enter A:  ");
int B = ReadNumber("Enter B:  ");

int exp = Exponent(A, B);
Console.WriteLine("Ответ: " + exp);