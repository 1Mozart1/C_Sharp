﻿// System.Console.Write("Введите число: "); // 
// int num = Convert.ToInt32(Console.ReadLine());// (int.Parse() || Convert.ToInt32() - конвертирование строки) - ввод данных пользователем

// int res = num * num;

// System.Console.WriteLine("Квадрат числа равен: " + res + " Text");
// System.Console.WriteLine($"Квадрат числа равен: {res} Text");

//////////////////////////////// Задача: является ли число a, квадратом числа b *********************************************** 

// System.Console.Write("Введите число а: ");
// int num_A = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите число b: ");
// int num_B = Convert.ToInt32(Console.ReadLine());

// if (num_B * num_B == num_A)
// {
//     System.Console.WriteLine("Является квадратом числа");
// }
// else 
// {
//     System.Console.WriteLine("Не является квадратом числа");
// }

///////////////////////////////////// Задача "Дни недели"*******************************************************************

// System.Console.Write("Введите день недели: ");
// int day = Convert.ToInt32(Console.ReadLine());

// if(day == 1)
// {
//     System.Console.WriteLine("Понедельник");
// }
// else if(day == 2)
// {
// System.Console.WriteLine("Вторник");
// }
// else if(day == 3)
// {
// System.Console.WriteLine("Среда");
// }
// else if(day == 4)
// {
// System.Console.WriteLine("Четверг");
// }
// else if(day == 5)
// {
// System.Console.WriteLine("Пятница");
// }
// else if(day == 6)
// {
// System.Console.WriteLine("Суббота");
// }
// else if(day == 7)
// {
// System.Console.WriteLine("Воскресенье");
// }
// else 
// {
// System.Console.WriteLine("Такого дня нет");
// }

// Можно сделать через SWITCH CASE****************************************

// System.Console.Write("Введите день недели: ");
// int day = Convert.ToInt32(Console.ReadLine());

// switch (day)
// {
//     case 1:
//         System.Console.WriteLine("Понедельник");
//         break;
//     case 2:
//         System.Console.WriteLine("Вторник");
//         break;
//     case 3:
//         System.Console.WriteLine("Среда");
//         break;
//     case 4:
//         System.Console.WriteLine("Четверг");
//         break;
//     case 5:
//         System.Console.WriteLine("Пятница");
//         break;
//     case 6:
//         System.Console.WriteLine("Суббота");
//         break;
//     case 7:
//         System.Console.WriteLine("Воскресенье");
//         break;
//     default:
//         System.Console.WriteLine("Такого дня не существует");
//         break;
// }

/////Задача на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.*********************

// System.Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// for (int i = -num; i <= num; i++)
// {
//     System.Console.Write(i + " ");
// }

/////Задача "вход трёхзначное число и на выходе показывает последнюю цифру этого числа"*******************************************

// System.Console.Write("Введите трехзначное число: ");
// int num = Math.Abs(Convert.ToInt32(Console.ReadLine())); // Math.Abc  -  это метод математического класса, который используется для возврата абсолютного значения указанного числа

// if (num > 99 && num < 1000)
// {
//     System.Console.WriteLine("Последнее число " + num % 10);
// }
// else
// {
//     System.Console.WriteLine("Введено не трехзначное число");
// }



////////////////////////////////////////////////////////  Семинар № 2 ////////////////////////////////////////////////////////


// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.****************

// Random rand = new Random();
// int num = rand.Next(10, 100);
// System.Console.WriteLine($"Случайное число: {num}");

// // int leftnum = num / 10;  Данные вычесления можно сразу внести в условие
// // int rightnum = num % 10;

// if (num / 10 > num % 10)
// {
//     System.Console.WriteLine($"Левое число больше и равно: {num / 10}");
// }
// else if(num / 10 < num % 10)
// {
//     System.Console.WriteLine($"Правое число больше и равно: {num % 10}");
// }
// else
// {
//     System.Console.WriteLine($"Числа равны");
// }

/////////Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.*********************

// Random rand = new Random();
// int num = rand.Next(100, 1000);
// System.Console.WriteLine($"Случайное число: {num}");

// System.Console.WriteLine($"{num / 100}{num % 10}");


///// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому*********

// System.Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a % b == 0)
// {
//     System.Console.WriteLine($"Число кратное");
// }
// else
// {
//     System.Console.WriteLine($"Число не кратное, остаток : {a % b}");
// }


///// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.************************

// System.Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// if(a%7==0 && a%23==0)
// {
//     System.Console.WriteLine($"Число {a} кратно 7 и 23");
// }
// else
// {
//     System.Console.WriteLine($"Число {a} некратно 7 и 23");
// }


///// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого*************

// System.Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a / b == b)
// {
//     System.Console.WriteLine($"Число {a} является квадратом числа {b}");
// }
// else if (b / a == a)
// {
//     System.Console.WriteLine($"Число {b} является квадратом числа {a}");
// }
// else
// {
//     System.Console.WriteLine($"Числа не являются друг другу квадратами");
// }


///// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), ************************************
///// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.**********************************

// int input_num(string str)                         // функция ввода числа, принимает строку, а возвращает число
// {
//     System.Console.Write(str);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void FindQuarter(int a, int b)                  // Функция нахождения 
// {
//     if (a > 0 && b > 0)
//     {
//         System.Console.WriteLine("Номер четверти 1");
//     }
//     else if (a < 0 && b > 0)
//     {
//         System.Console.WriteLine("Номер четверти 2");
//     }
//     else if (a < 0 && b < 0)
//     {
//         System.Console.WriteLine("Номер четверти 3");
//     }
//     else if (a > 0 && b < 0)
//     {
//         System.Console.WriteLine("Номер четверти 4");
//     }
//     else
//     {
//         System.Console.WriteLine("Точка находится в начале координат");
//     }
// }

// int x = input_num("Введите координату x: ");
// int y = input_num("Введите координату y: ");

// FindQuarter (x , y);


// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// System.Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// string [] arr = {"x>0, y>0", "x<0, y>0", "x<0, y<0", "x>0, y<0", "Нет такой четверти"};

// if (a == 1)
// {
//     System.Console.WriteLine(arr[0]);
// }
// else if (a == 2)
// {
//     System.Console.WriteLine(arr[1]);
// }
// else if (a==3)
// {
//     System.Console.WriteLine(arr[2]);
// }
// else if (a==4)
// {
//     System.Console.WriteLine(arr[3]);
// }
// else
// {
//     System.Console.WriteLine(arr[4]);
// }

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//Math.Pow(x, y); // функция возведения в степень (x - число, y - степень)
//Math.Sqrt // Функция поиска корня числа

// int input_num(string str)
// {
//     System.Console.Write(str);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int x1 = input_num("Введите координату x1: ");
// int y1 = input_num("Введите координату y1: ");
// int x2 = input_num("Введите координату x2: ");
// int y2 = input_num("Введите координату y2: ");

// System.Console.WriteLine(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));

// // ИЛИ
// // Math.Round (a, 3) - округление 1-е это чило, 2-е до скольки знаков

// System.Console.WriteLine(Math.Round(Math.Pow(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2), 0.5), 3));


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// System.Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// // int count = 1;
// // while (count<=a)
// // {
// //     System.Console.Write(Math.Pow(count, 2) + ", ");
// //     count ++;
// // }
// for (int count = 1; count <= a; count++)
// {
//     System.Console.Write(Math.Pow(count, 2) + ", ");
// }


// Lesson # 4  ******************************************************************************************************************

// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// System.Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// if(a/10000 == a%10 && a/1000 %10 == a%10000/1000)
// {
//     System.Console.WriteLine("Число является палиндромом");
// }
// else
// {
//     System.Console.WriteLine("Число не является палиндромом");
// }


//    int? a = Console.ReadLine() - знак ? ставится для того чтобы в ячейку записывалось значение NULL ???????????????????????
//    if(a!.Lenght == 5) - знак  !  ставится для методов !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


//Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А. 
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int GetNumber(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int GetSumElements(int A)
// {
//     int result = 0;

//     for (int i = 1; i <= A; i++)
//     {
//         result += i;
//     }
//     return result;
// }

// int num = GetNumber("Введите число A: ");

// System.Console.WriteLine($"Сумма чисел от 1 до {num} = {GetSumElements(num)}");


// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.*********************
// 456 -> 3
// 78 -> 2
// 89126 -> 5


// string? GetNumber(string text)
// {
//     System.Console.Write(text);
//     return Console.ReadLine();
// }
// string? num = GetNumber("Введите число A: ");
// int result = num!.Length;
// System.Console.WriteLine(result);



//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//           4 -> 24 
//           5 -> 120

// int GetNumber(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int Multiply(int a)
// {
//     int result = 1;
//     for (int i = 1; i <= a; i++)
//     {
//         result = result * i;
//     }
//     return result;
// }
// int num = GetNumber("Введите число N: ");
// System.Console.WriteLine($"Произведение чисел от 1 до {num} = {Multiply(num)}");




// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//            [1,0,1,1,0,1,0,0]


// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
// }
// int[] FillArray(int size)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(0, 2);
//     }
//     return arr;
// }

// int[] myArray = FillArray(16);
// PrintArray(myArray);


//-------------Версия № 2

int[] GetArray()
{
var arr = new int[10];
var rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rand.Next(0, 2);
}
return arr;
}

void PrintArray(int[] arr)
{
System.Console.WriteLine("["+string.Join(", ", arr)+"]");   // заполнение массива в одну строку вместо
}

var myArray = GetArray();
PrintArray(myArray);


//--------------- Версия 3

// void GetArray(int[] arr)
// {
//     var rand = new Random();
//     for (int i = 0; i < arr.Length; i++)                           
//     {
//         arr[i] = rand.Next(0, 2);
//     }
// }

// void PrintArray(int[] arr)
// {
//     System.Console.WriteLine("[" + string.Join(", ", arr) + "]");  
// }

// int[] myArray = new int[8];
// GetArray(myArray);
// PrintArray(myArray);
