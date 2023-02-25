// Задача 54: Задайте двумерный массив. 
//            Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.***********************

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



//Задача 56: Задайте прямоугольный двумерный массив. **************************************************************************
//           Напишите программу, которая будет находить строку с наименьшей суммой элементов.***********************************

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


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*************************

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
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }


// void Check(int[,] matrix1, int[,] matrix2)
// {
//     if(matrix1.GetLength(1) != matrix2.GetLength(0))
//     {
//         System.Console.WriteLine($"Такие массивы перемножить нельзя !!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
//     }
// }

// int[,] ResultMatrix(int[,] matrix1, int[,] matrix2)
// {
//     int[,] result = new int[matrix1.GetLength(0), matrix2.GetLongLength(1)];
//     for (int i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix2.GetLongLength(1); j++)
//         {
//             result[i, j] = 0;
//             for (int k = 0; k < matrix1.GetLength(1); k++)
//             {
//                 result[i, j] += matrix1[i, k] * matrix2[k, j];
//             }
//         }
//     }
//     return result;
// }



// int rowsA = ReadInt("Введите количество строк маcсива А: ");
// int colsA = ReadInt("Введите количество столбцов маcсива А: ");
// var matrix1 = GenerateMatrix(rowsA, colsA);
// PrintMatrix(matrix1);
// System.Console.WriteLine();
// int rowsB = ReadInt("Введите количество строк маcсива Б: ");
// int colsB = ReadInt("Введите количество столбцов маcсива Б: ");
// var matrix2 = GenerateMatrix(rowsB, colsB);
// PrintMatrix(matrix2);

// System.Console.WriteLine();
// Check(matrix1, matrix2);
// System.Console.WriteLine();
// int[,] ResMatrix = ResultMatrix(matrix1, matrix2);
// System.Console.WriteLine("Результат перемножения двумерных массивов");
// PrintMatrix(ResMatrix);


//Задача 60: Сформируйте трёхмерный массив из двузначных чисел. ****************************************************************
//           Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.********************

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,,] GenerateMatrix(int rows, int cols, int depth)
// {
//     Random rand = new Random();
//     int[,,] array3D = new int[rows, cols, depth];

//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//                 array3D[i, j, k] = rand.Next(11, 100);
//             }
//         }

//     }
//     return array3D;
// }
// void PrintMatrix(int[,,] array3D)
// {
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)  
//         {
//             System.Console.WriteLine();
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//                 System.Console.Write($"{array3D[i, j, k]} в ячейке ({i},{j},{k}) | ");
//             }
//         }
//     }
// }


// int rows = ReadInt("Введите количество строк: ");
// int cols = ReadInt("Введите количество столбцов: ");
// int depth = ReadInt("Введите глубину массива: ");

// var myMatrix = GenerateMatrix(rows, cols, depth);
// PrintMatrix(myMatrix);



//********************** Задача 62: Заполните спирально массив 4 на 4.***********************************************************

// int[,] SpiralArray(int length)
// {
//     int row = 0;
//     int col = 0;
//     int size = length;
//     int[,] spiral = new int[size,size];
//     for (int i = 0; i < size * size; i++)
//     {
//         spiral[row, col] = i;
//         if (row <= col + 1 && row + col < size - 1) col++;
//         else if (row < col && row + col >= size - 1) row++;
//         else if (row >= col && row + col > size - 1) col--;
//         else row--;
//     }
//     return spiral;
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]}\t");
//         }
//     System.Console.WriteLine();
//     }
// }



// System.Console.Write("Введите размер массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// PrintMatrix(SpiralArray(length));
