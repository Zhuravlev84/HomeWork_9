/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/


int N = ReadInt("Введите число: ");
int M = 1;


Console.WriteLine(Number(M, N));

int Number(int m, int n)
{
    if (m == n)
        return m;
    else
    {
        Console.Write(Number(m + 1, n) + ", ");
    }
    return m;
}
int ReadInt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}