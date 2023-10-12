// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[m];

void FillArray(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива ");
        Array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
FillArray(m);

int kol(int[] Array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {   
        if (Array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine($"Кол-во элементов > 0: {kol(Array)}");