// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными(тип double) числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// int[,] massive = new double[3,4];

// PrintArray(massive);

// void PrintArray(int[,] mass)
// {
//     for (int i=0; i < mass.GetLength(0); i++)
//     {
//         for (int j=0; j < mass.GetLendth(1); j++)
//         {
//             Console.Write($"{mass[ i , j ]}");
//         }
//         Console.WriteLine();
//     }
// }

// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

double number = 5;
double firstElem = 0;
double secondElem = 1;

Console.WriteLine($"1. {firstElem}");
Console.WriteLine($"2. {secondElem}");

for (int i = 3; i <= number; i++)
{
    double nextElem = firstElem + secondElem;
    Console.WriteLine($"{i}. {nextElem}");
    firstElem = secondElem;
    secondElem = nextElem;
}