// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.************

// int input_num(string str)
// {
//     System.Console.Write(str);
//     return Convert.ToInt32(Console.ReadLine());
// }
// void degree(int a, int b)
// {
//     int sum = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         sum *= a;
//     }
//     System.Console.WriteLine(sum);
// }

// int a = input_num("Введите число a: ");
// int b = input_num("Введите число b: ");
// degree(a, b);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.********************************

// int Num(string text)
// {
//     Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int NumberLen(int a)
// {
//     int index = 0;
//     while (a > 0)
//     {
//         a /= 10;
//         index++;
//     }
//     return index;
// }

// void Sum(int b, int c)
// {
//     int sum = 0;
//     for (int i = 1; i <= c; i++)
//     {
//         sum += b % 10;
//         b /= 10;
//     }
//     Console.WriteLine(sum);
// }

// int number = Num("Введите число: ");
// int len = NumberLen(number);
// Sum(number, len);


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.**********************************

// int input_num(string str)
// {
//     System.Console.Write(str);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[] GetArray(int size, int left, int right)
// {
//     int[] arr = new int[size];
//     var rand = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rand.Next(left, right);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
// }

// int size = input_num("Введите размер массива ");
// int left = input_num("Введите левую границу массива ");
// int right = input_num("Введите правую границу массива ");
// var myarr = GetArray(size, left, right);
// PrintArray(myarr);