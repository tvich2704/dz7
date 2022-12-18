using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());

Write("Введите индекс строки: ");
int stroka = int.Parse(ReadLine());

Write("Введите индекс столбца: ");
int stolb = int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array, stroka, stolb);

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
void PrintArray(int[,] inArray, int line, int stolbik)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
    if (line < inArray.GetLength(0) && stolbik < inArray.GetLength(1))
    {
        WriteLine($"{line},{stolbik}->{inArray[line,stolbik]}");
    }
    else
    {
        WriteLine($"{line},{stolbik}->такого числа в массиве нет");
    } 
    
}

