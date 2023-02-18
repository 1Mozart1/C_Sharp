// System.Console.Write("Введите число: "); // 
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

// int[] GetArray()
// {
// var arr = new int[10];
// var rand = new Random();
// for (int i = 0; i < arr.Length; i++)
// {
// arr[i] = rand.Next(0, 2);
// }
// return arr;
// }

// void PrintArray(int[] arr)
// {
// System.Console.WriteLine("["+string.Join(", ", arr)+"]");   // заполнение массива в одну строку вместо
// }

// var myArray = GetArray();
// PrintArray(myArray);


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



// Lesson # 5  Функции и одномерные массивы  ***************************************************************************************


// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] GenerateArray(int size, int leftrange, int rightrange)
// {
//     int[] array = new int[size];                           //
//     var rand = new Random();                                //
//     for (int i = 0; i < array.Length; i++)                     //  создание рандомно заполняемого массива
//     {                                                       //  по заданным условиям 
//         array[i] = rand.Next(leftrange, rightrange + 1);    //
//     }                                                       //            
//     return array;                                           //
// }


// void PrintArray(int[] array)
// {
//     System.Console.WriteLine("[" + string.Join(", ", array) + "]"); // string.Join - позволяет выводить массив через заданный разделитель 
// }

// int SumNegative(int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//         {
//             result += array[i];
//         }
//     }
//     return result;
// }

// int SumPositive(int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             result += array[i];
//         }
//     }
//     return result;
// }

// int[] myArray = GenerateArray(6, -9, 9);
// PrintArray(myArray);
// System.Console.WriteLine($"Сумма отрицательных чисел равна: {SumNegative(myArray)}");
// System.Console.WriteLine($"Сумма положительных чисел равна: {SumPositive(myArray)}");

// *****  ИЛИ  *******

// int[] GenerateArray(int size, int leftrange, int rightrange)
// {
//     int[] array = new int[size];                           //
//     var rand = new Random();                                //
//     for (int i = 0; i < array.Length; i++)                     //  создание рандомно заполняемого массива
//     {                                                       //  по заданным условиям 
//         array[i] = rand.Next(leftrange, rightrange + 1);    //
//     }                                                       //            
//     return array;                                           //
// }


// void PrintArray(int[] array)
// {
//     System.Console.WriteLine("[" + string.Join(", ", array) + "]"); // string.Join - позволяет выводить массив через заданный разделитель 
// }

// int[] SumPositiveAndNegative(int[] array)
// {
//     int[] result = new int[2];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//         {
//             result[0] += array[i];
//         }
//         else
//         {
//             result[1] += array[i];
//         }
//     }
//     return result;
// }

// int[] myArray = GenerateArray(6, -9, 9);
// PrintArray(myArray);
// int[] sums = SumPositiveAndNegative(myArray);
// System.Console.WriteLine($"Сумма отрицательных чисел равна: {sums[0]}");
// System.Console.WriteLine($"Сумма положительных чисел равна: {sums[1]}");

// *****  ИЛИ  *******

// int[] GenerateArray(int size, int leftrange, int rightrange)
// {
//     int[] array = new int[size];                           //
//     var rand = new Random();                                //
//     for (int i = 0; i < array.Length; i++)                     //  создание рандомно заполняемого массива
//     {                                                       //  по заданным условиям 
//         array[i] = rand.Next(leftrange, rightrange + 1);    //
//     }                                                       //            
//     return array;                                           //
// }


// void PrintArray(int[] array)
// {
//     System.Console.WriteLine("[" + string.Join(", ", array) + "]"); // string.Join - позволяет выводить массив через заданный разделитель 
// }

// void SumPositiveAndNegative(int[] array, out int sumPositive, out int sumNegative)
// {
//     sumNegative = 0;
//     sumPositive = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//         {
//             sumNegative += array[i];
//         }
//         else
//         {
//             sumPositive += array[i];
//         }
//     }

// }

// int[] myArray = GenerateArray(6, -9, 9);
// PrintArray(myArray);
// SumPositiveAndNegative(myArray, out int sumPositive, out int sumNegative);
// System.Console.WriteLine($"Сумма отрицательных чисел равна: {sumNegative}");
// System.Console.WriteLine($"Сумма положительных чисел равна: {sumPositive}");


// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, 
//            и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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

// void changeArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)                   
//     {                                                        
//         array[i] = -array[i];    
//     }                                                                                                       
// }

// int[] myArray = GenerateArray(6, -9, 9);
// PrintArray(myArray);
// changeArray(myArray);
// PrintArray(myArray);



// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

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

// bool FindNumber(int[] array, int number)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//         {
//             return true;
//         }
//     }
//     return false;
// }

// int[] myArray = GenerateArray(6, -9, 9);
// int number = 7;
// PrintArray(myArray);
// if(FindNumber(myArray, number))
// {
//     System.Console.WriteLine($"Есть такое число");
// }
// else
// {
//     System.Console.WriteLine($"Такого числа нет");
// }

//*********** ИЛИ  **************

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

// void FindNumber(int[] array, int number)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//         {
//             System.Console.WriteLine("Есть такое число");
//             return;
//         }
//     }
//     System.Console.WriteLine("Нет такого элемента");

// }

// int[] myArray = GenerateArray(6, -9, 9);
// int number = 7;
// PrintArray(myArray);
// FindNumber(myArray, number);



// *************************************************************  функция поиска по индексу  *************

// int[] arr = { 0, 1, 2, 3, 4, 5, 6, };
// System.Console.WriteLine(Array.IndexOf(arr, 5)); // показывает индекс искомого элемента, если показывает "-1" то такого элемента нет


// Задача 35: Задайте одномерный массив из 123 случайных чисел. ******************************************
//            Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 


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

// int GetResult(int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 10 && array[i] <= 99)
//         {
//             result++;
//         }
//     }
//     return result;
// }


// int[] myArray = GenerateArray(30, -100, 100);
// PrintArray(myArray);
// System.Console.WriteLine(GetResult(myArray));


// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//            Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

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

// int[] GetResult(int[] array)
// {
//     int size;
//     if (array.Length == 0)
//         size = array.Length / 2;
//     else
//         size = array.Length / 2 + 1;

//     int[] arrResult = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arrResult[i] = array[i] * array[array.Length - 1 - i];
//     }
//     if (array.Length % 2 != 0) // != - означает не равняется
//     {
//         arrResult[arrResult.Length - 1]= array[size - 1];
//     }
//     return arrResult;
// }

// int[] myArray = GenerateArray(5, 1, 10);
// PrintArray(myArray);
// int[] res = GetResult(myArray);
// PrintArray(res);



// Lesson # 6  Одномерные массивы    **********************************************************************************************


// Задача 39: Напишите программу, которая перевернёт одномерный массив 
//            (последний элемент будет на первом месте, а первый - на последнем и т.д.)


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

// // void ReverseArray(int[] array)                   //
// // {    
// //     int temp;                                    //
// //     for (int i = 0; i < array.Length / 2; i++)   //
// //     {                                                     // вместо этого Array.Reverse - переворачивает массив    
// //         temp = array[i];                         //
// //         array[i] = array[array.Length - i - 1];  //
// //         array[array.Length - i - 1] = temp;      //
// //     }
// // }

// int[] myArray = GenerateArray(6, 1, 10);
// PrintArray(myArray);
// Array.Reverse(myArray);
// PrintArray(myArray);


//  Задача 40:  Напишите программу, которая принимает на вход три числа и проверяет, 
//              может ли существовать треугольник с сторонами такой длины.

// metka:
// System.Console.Write("Введите числа: ");
// // Split - по умолчанию разделяет через пробел или Split(";")
// int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); // Console.ReadLine().Split() -первый параметр строковы массив
// // записывает из термина(ввод пользователем) числа в массив;            // int.Parse - второй параметр конвертирует в указанное значение       

// if(array.Length!= 3)
// {
//     System.Console.WriteLine("массив введен некоректно");
//     goto metka;                                             // ОТПРАВЛЯЕТ К МЕТКЕ
// }
// else if ((array[0] + array[1]) > array[2] && array[1] + array[2] > array[0] && array[0] + array[2] > array[1])
// {
//     System.Console.WriteLine("Такой треугольник существует");
// }
// else
// {
//     System.Console.WriteLine("Такой треугольник не существует");
// }


// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// System.Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// string st = " ";

// while (n != 0)
// {
//     st += n % 2;
//     n = n / 2;
// }
// for (int i = st.Length - 1; i >= 0; i--)
// {
//     System.Console.Write(st[i]);
// }
// System.Console.WriteLine();


// ИЛИ - РЕКУРСИЯ  ***********************

// void GetBinatyView(int number)
// {
//     if (number <= 0) return;
//     GetBinatyView(number / 2);
//     System.Console.Write(number % 2);
// }

// System.Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// GetBinatyView(n);

// ИЛИ - КОНВЕРТАЦИЯ В СТРОКУ******************

// System.Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Convert.ToString(n, 2));


// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//            Если N = 5 -> 0 1 1 2 3
//            Если N = 3 -> 0 1 1
//            Если N = 7 -> 0 1 1 2 3 5 8


// System.Console.Write("Введите число: ");
// int F = Convert.ToInt32(Console.ReadLine());
// int F0 = 0;
// int F1 = 1;

// System.Console.Write("0 1 ");
// for (int i = 0; i < F - 2; i++)
// {
//     int sum = F0 + F1;
//     System.Console.Write(sum + " ");
//     F0 = F1;
//     F1 = sum;
// }



// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

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

// int[] CopyPaste(int[] array)
// {
//     int[] array2 = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array2[i] = array[i];
//     }
//     return array2;
// }

// int[] myArray = GenerateArray(6, 1, 10);
// PrintArray(myArray);
// int[] CopyArray = CopyPaste(myArray);
// PrintArray(CopyArray);

// ИЛИ

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

// int[] myArray = GenerateArray(6, 1, 10);
// PrintArray(myArray);
// int[] arrayCopy = myArray[..]; // копия массива одной строкой с выделением памяти  ++++++++++++++++++++++++++
// PrintArray(arrayCopy);



// Lesson # 7  Двумерный массивы    **********************************************************************************************


// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами. m = 3, n = 4.

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

// int rows = ReadInt("Введите количество строк: ");
// int cols = ReadInt("Введите количество столбцов: ");

// var myMatrix = GenerateMatrix(rows, cols);
// PrintMatrix(myMatrix);


// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
//            Выведите полученный массив на экран.
//            rows = 3, cols = 4.
//            0 1 2 3
//            1 2 3 4
//            2 3 4 5

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GenerateMatrix(int rows, int cols)
// {
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = i + j;
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

// int rows = ReadInt("Введите количество строк: ");
// int cols = ReadInt("Введите количество столбцов: ");

// var myMatrix = GenerateMatrix(rows, cols);
// PrintMatrix(myMatrix);


// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// Например, изначально массив      Новый массив будет выглядеть 
// выглядел вот так:                вот так:
// 1 4 7 2                          1 4 7 2                     
// 5 9 2 3                          5 (81) 2 (9)                 
// 8 4 2 4                          8 4 2 4 

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

// void square(int[,] matrix)
// {
//     for (int i = 1; i < matrix.GetLength(0); i += 2)
//     {
//         for (int j = 1; j < matrix.GetLength(1); j += 2)
//         {
//             if (i % 2 != 0 && j % 2 != 0)
//             {
//                 matrix[i, j] = matrix[i, j] * matrix[i, j];
//             }
//         }
//     }
// }


// int rows = ReadInt("Введите количество строк: ");
// int cols = ReadInt("Введите количество столбцов: ");

// var myMatrix = GenerateMatrix(rows, cols);
// PrintMatrix(myMatrix);
// square(myMatrix);
// System.Console.WriteLine();
// PrintMatrix(myMatrix);


// Задача 51: Задайте двумерный массив. Найти сумму элементов на главной диагонали
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12



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

// // // int SumElements(int[,] matrix)
// // // {
// // //     int sum = 0;
// // //     for (int i = 0; i < matrix.GetLength(0); i++)
// // //     {
// // //         for (int j = 0; j < matrix.GetLength(1); j++)
// // //         {
// // //             if (i == j)
// // //             {
// // //                 sum += matrix[i, j];
// // //             }
// // //         }
// // //     }
// // //     return sum;
// // // }
// // //      ИЛИ

// // int SumElements(int[,] matrix)
// // {
// //     int sum = 0;
// //     int length = (matrix.GetLength(0) < matrix.GetLength(1)) ? matrix.GetLength(0) : matrix.GetLength(1); // вместо IF ELSE
// //     // if (matrix.GetLength(0) < matrix.GetLength(1))
// //     //     length = matrix.GetLength(0);
// //     // else length = matrix.GetLength(1);
// //     for (int i = 0; i < length; i++)
// //     {
// //         sum += matrix[i, i];
// //     }
// //     return sum;
// // }
// //      ИЛИ 

// int SumElements(int[,] matrix)
// {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
//     {
//         sum += matrix[i, i];
//     }
//     return sum;
// }


// int rows = ReadInt("Введите количество строк: ");
// int cols = ReadInt("Введите количество столбцов: ");

// var myMatrix = GenerateMatrix(rows, cols);
// PrintMatrix(myMatrix);
// System.Console.WriteLine($"Сумма элементов главной диагонали = {SumElements(myMatrix)}");

