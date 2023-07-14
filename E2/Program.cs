// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 1, j = 2 -> 2
// i = 4, j = 2 -> такого элемента не существует

int rows = new Random().Next(2,11);
int coloms = new Random().Next(2,11);

Console.Write("Введите позиции элемента, который хотите увидеть из массива: ");
int r = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);

int[,] massive = new int[rows,coloms];
FillArray(massive);

Console.Write("Исходный массив: ");
PrintArray(massive);
Console.WriteLine();

 if (r > rows || c > coloms)
    {
        Console.Write("Такого  элемента не существует в массиве.");
    }
    else
    {
        FindEl(massive, r, c);
    }

void FindEl(int[,] mass, int rr, int cc)
{
    for (int i=0; i < mass.GetLength(0); i++)
    {
        for (int j=0; j < mass.GetLength(1); j++)
        {
            if (i==rr && j==cc) 
            {
                Console.Write($"Искомый элемент массива это: {mass[ i , j ] }  ");
            }
        
        }

    }
}


void PrintArray(int[,] mass)
{
    for (int i=0; i < mass.GetLength(0); i++)
    {
        for (int j=0; j < mass.GetLength(1); j++)
        {
            Console.Write($"{mass[ i , j ] }  ");
        }
        Console.WriteLine();
    }
}


void FillArray(int[,] mass)
{
    for (int i=0; i < mass.GetLength(0); i++)
    {
        for (int j=0; j < mass.GetLength(1); j++)
        {
            mass[i,j] = new Random().Next(0,11);
        }
    }
}