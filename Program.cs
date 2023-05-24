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

// Console.Write("Введите значение M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int summ(int M, int N)
// {
// if (M==N)
//     return N;
// else 
//     return M + summ(M + 1, N);
// }
// Console.Write(summ(M,N));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

int akermann(int M, int N)
{
if (M == 0) 
    return N + 1;
else if (N == 0) 
    return akermann(M-1, 1);
else 
    return akermann(M-1, akermann(M, N-1));
}

Console.Write(akermann(M, N));