// Задача 54: Задайте двумерный массив. 
//            Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.----------------------

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

// void Decrease(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(1) - 1; k++)
//             {
//                 int temp = 0;
//                 if (matrix[i, k] < matrix[i, k + 1])
//                 {
//                     temp = matrix[i, k + 1];
//                     matrix[i, k + 1] = matrix[i, k];
//                     matrix[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// int rows = ReadInt("Введите количество строк: ");
// int cols = ReadInt("Введите количество столбцов: ");

// var myMatrix = GenerateMatrix(rows, cols);
// PrintMatrix(myMatrix);
// System.Console.WriteLine();
// Decrease(myMatrix);
// PrintMatrix(myMatrix);



//Задача 56: Задайте прямоугольный двумерный массив. 
//           Напишите программу, которая будет находить строку с наименьшей суммой элементов.------------------------------------

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


// void MinSumRow(int[,] matrix)
// {
//     int sumRow = 0;
//     int minSum = 0;
//     int row = 0;
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         minSum += matrix[0, i];
//     }
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         sumRow = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sumRow += matrix[i, j];
//         }
//         if (sumRow < minSum)
//         {
//             minSum = sumRow;
//             row = i;
//         }
//     }
//     System.Console.WriteLine($"Строка с минимальной суммой чисел № {row + 1} = {minSum}");
// }

// int rows = ReadInt("Введите количество строк: ");
// int cols = ReadInt("Введите количество столбцов: ");

// var myMatrix = GenerateMatrix(rows, cols);
// PrintMatrix(myMatrix);

// MinSumRow(myMatrix);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.-----------------------


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
            System.Console.Write(matrix[i, j] + "\t"); // \t - это табуляция (tab)
        }
        System.Console.WriteLine();
    }
}

void Check(int[,] matrix1, int[,] matrix2)
{
    if(matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        System.Console.WriteLine($"Такие массивы перемножить нельзя");
    }
    
}

int[,] ResultMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLongLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLongLength(1); j++)
        {
            result[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return result;
}



int rowsA = ReadInt("Введите количество строк матрицы А: ");
int colsA = ReadInt("Введите количество столбцов матрицы А: ");
var matrix1 = GenerateMatrix(rowsA, colsA);
PrintMatrix(matrix1);
System.Console.WriteLine();
int rowsB = ReadInt("Введите количество строк матрицы Б: ");
int colsB = ReadInt("Введите количество столбцов матрицы Б: ");
var matrix2 = GenerateMatrix(rowsB, colsB);
PrintMatrix(matrix2);
System.Console.WriteLine();
Check(matrix1, matrix2);
int[,] ResMatrix = ResultMatrix(matrix1, matrix2);
PrintMatrix(ResMatrix);