/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int M = ReadInt("Введите число от которого считать: ");
int N = ReadInt("Введите число до которого считать(включительно): ");

Console.WriteLine($"M = {M}; N = {N} --> {NaturalNumber(M, N)}");

int NaturalNumber(int m, int n)
{
    if (m == n)
        return m;
    else
    {
        return m + NaturalNumber(m + 1, n);
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}