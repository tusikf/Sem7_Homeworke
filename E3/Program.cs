// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое* элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// * Сумма всех цифр / их количество(это количество ваших строк)


Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int colom = int.Parse(Console.ReadLine()!);

int[,] massive = new int[row,colom];

FillArray(massive);
Console.WriteLine("Исходный массив: ");
PrintArray(massive);
Console.WriteLine();

Console.WriteLine("Среднее арифметическое столбцов массива: ");
FindeSra(massive);

void FindeSra(int[,] mass)
{
    int summ = 0; 
    double sra = 0;
    for (int j=0; j < mass.GetLength(1); j++)
    {
        for (int i=0; i < mass.GetLength(0); i++)
        {
            summ += mass[i,j];         
        }
        sra = (double) summ / mass.GetLength(0);
        Console.WriteLine($"Столбца № {j+1} = {sra:0.000} ");
        summ = 0;
        sra = 0;
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