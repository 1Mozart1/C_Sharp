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
