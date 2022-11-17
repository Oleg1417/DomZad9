//                                      Задача 64:
// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//                в промежутке от N до 1. Выполнить с помощью рекурсии.

// Console.WriteLine("Введите число:");
// int N = int.Parse(Console.ReadLine()!);
// int end = 1;

// string Numbers(int N)
// {
//     if (N == end) return end.ToString();
//     else
//     {
//         return (N + ", " + Numbers(N - 1));
//     }
// }

// Console.WriteLine(Numbers(N));




//                                      Задача 66:
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
//                          элементов в промежутке от M до N.

// Console.WriteLine("Введите число M:");
// int M = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число N:");
// int N = int.Parse(Console.ReadLine()!);

// int SumElement(int start, int end)
// {

//     if (start == end) return 0;
//     return start + SumElement(start + 1, end);
// }

// Console.WriteLine($"Сумма натуральных элементов равна: {SumElement(M, N+1)}");

//                                      Задача 68:
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//                      Даны два неотрицательных числа m и n

int m = 2;
int n = 3;

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return (Akkerman(m - 1, Akkerman(m, n - 1)));
    return Akkerman(m, n);
}
Console.WriteLine(Akkerman(m, n));