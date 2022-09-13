// Задача 50. Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Clear();
int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

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

void FindNum(int[,] matrix, int numRow, int numColumn)
{for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (numRow == i+1 && numColumn == j+1)
        {
            Console.WriteLine($"Число в строке {numRow} и колонке {numColumn} = {matrix[i, j]}");
            return;
        }
    }
}
Console.WriteLine("Такого числа в массиве нет");
}

int[,] myArray = FillArray(4, 3);
PrintArray(myArray);
int row = Prompt("Введите номер строки: ");
int column = Prompt("Введите номер колонки: ");
FindNum(myArray, row, column);