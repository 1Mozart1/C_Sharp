// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// System.Console.Write("Введите числа: ");
// var array = Array.ConvertAll(Console.ReadLine().Split(), string.Parse);

// string res = 0;
// for (string i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//         res++;

// }

// System.Console.WriteLine(res);


// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
//            заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


// double GetNumber(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// double GetNum_X(double b1, double k1, double b2, double k2)
// {
//     double x = 0;
//     x = (b2 - b1) / (k1 - k2);
//     return x;
// }
// double GetNum_Y(double b, double k, double x)
// {
//     double y = 0;
//     y = k * x + b;
//     return y;
// }

// double num_b1 = GetNumber("Введите число b1: ");
// double num_k1 = GetNumber("Введите число k1: ");
// double num_b2 = GetNumber("Введите число b2: ");
// double num_k2 = GetNumber("Введите число k2: ");
// double X = GetNum_X(num_b1, num_k1, num_b2, num_k2);
// double y1 = GetNum_Y(num_b1, num_k1, X);
// double y2 = GetNum_Y(num_b2, num_k2, X);
// System.Console.WriteLine($"прямые пересекутся в точке ({y1}; {y2})");
