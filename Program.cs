// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// PrintNumbers (N);

// void PrintNumbers (int N)
// {
//     if (N<1)
//     {
//         return;
//     }
//     Console.Write(N + " ");
//     PrintNumbers (N-1);
// }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
int summ(int M, int N)
{
if (M==N)
    return N;
else 
    return M + summ(M + 1, N);
}
Console.Write($"{summ(M,N)}");