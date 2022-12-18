using System;
using static System.Console;

Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array, rows);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray, int m)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        double count = 0;
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            count += inArray[j,i];
        }
        WriteLine($"Среднее арифмитическое столбца {i + 1}->{count / m:f2}");
    }
}

