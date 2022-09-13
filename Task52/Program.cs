// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();

int[,] FillArray(int numLine, int NumColumns)
{
    int[,] matrix = new int[numLine, NumColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)     // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // Столбец
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void CalcAvg(int[,] matrix)
{
    double avg = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int sum = 0;
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
            count++;
        }
        avg = (double)sum / count;
        Console.Write($"{avg:f1}  ");

        Console.WriteLine();
    }
}

int[,] myArray = FillArray(3, 4);
PrintArray(myArray);
CalcAvg(myArray);