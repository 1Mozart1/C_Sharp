// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// double[,] GenerateMatrix(int rows, int cols)
// {
//     Random rand = new Random();
//     double[,] matrix = new double[rows, cols];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = Math.Round(rand.Next(0, 11) + rand.NextDouble(), 1);
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t"); // \t - это табуляция (tab)
//         }
//         System.Console.WriteLine();
//     }
// }

// int rows = ReadInt("Введите количество строк: ");
// int cols = ReadInt("Введите количество столбцов: ");

// var myMatrix = GenerateMatrix(rows, cols);
// PrintMatrix(myMatrix);


//  Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//             и возвращает значение этого элемента или же указание, что такого элемента нет.

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GenerateMatrix(int rows, int cols)
// {
//     Random rand = new Random();
//     int[,] matrix = new int[rows, cols];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(0, 11);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t"); // \t - это табуляция (tab)
//         }
//         System.Console.WriteLine();
//     }
// }


// void FindNum(int[,] matrix, int findRow, int findCol)
// {
//     if (findRow < 0 | findRow > matrix.GetLength(0) - 1 | findCol < 0 | findCol > matrix.GetLength(1) - 1)
//     {
//     Console.Write("Такого числа в массиве нет");
//     }
//     else
//     {
//     Console.Write($"число {matrix[findRow, findCol]} на этой позиции");
//     }
// }


// int rows = new Random().Next(3, 7);
// int cols = new Random().Next(3, 7);
// int[,] myMatrix = GenerateMatrix(rows, cols);
// PrintMatrix(myMatrix);

// int findRow = ReadInt($"Введите номер строки: ");
// int findCol = ReadInt($"Введите номер столбца: ");

// FindNum(myMatrix, findRow, findCol);



// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t"); 
        }
        System.Console.WriteLine();
    }
}

void Average(int[,] matrix)
{
    double sum = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }

        if (j == 0) 
        Console.WriteLine("Среднее арифметическое по столбцам:");
        Console.Write($"{Math.Round(sum / matrix.GetLength(0), 1)} \t");

        sum = 0;
    }
}

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");

var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
Average(myMatrix);