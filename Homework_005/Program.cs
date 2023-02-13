// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//            Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] GenerateArray(int size, int leftrange, int rightrange)
// {
//     int[] array = new int[size];
//     var rand = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(leftrange, rightrange + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     System.Console.WriteLine("[" + string.Join(", ", array) + "]");
// }

// void EvenNumbers(int[] array)
// {
//     int res = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//             res++;
//     }
//     System.Console.WriteLine($"Четных чисел в массиве: {res} ");
// }


// int[] myArray = GenerateArray(10, 100, 999);
// PrintArray(myArray);
// EvenNumbers(myArray);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] GenerateArray(int size, int leftrange, int rightrange)
// {
//     int[] array = new int[size];
//     var rand = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(leftrange, rightrange + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     System.Console.WriteLine("[" + string.Join(", ", array) + "]");
// }

// void Sum(int[] array)
// {
//     int res = 0;
//     for (int i = 1; i < array.Length; i+=2)
//     {
//         res+= array[i];
//     }
//     System.Console.WriteLine($"Сумма элементов: {res} ");
// }


// int[] myArray = GenerateArray(6, -10, 20);
// PrintArray(myArray);
// Sum(myArray);


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] GenerateArray(int size, int leftrange, int rightrange)
{
    double[] array = new double[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftrange, rightrange + 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join("| ", array) + "]");
}

void difference(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i ++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    System.Console.WriteLine($"{max - min}");
}

double[] myArray = GenerateArray(6, 1, 20);
PrintArray(myArray);
difference(myArray);

