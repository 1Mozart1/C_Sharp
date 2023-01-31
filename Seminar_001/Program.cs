// System.Console.Write("Введите число: "); // 
// int num = Convert.ToInt32(Console.ReadLine());// (int.Parse() || Convert.ToInt32() - конвертирование строки) - ввод данных пользователем

// int res = num * num;

// System.Console.WriteLine("Квадрат числа равен: " + res + " Text");
// System.Console.WriteLine($"Квадрат числа равен: {res} Text");

//////////////////////////////// Задача: является ли число a, квадратом числа b ///////////////////////////////////////////////////// 

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

///////////////////////////////////// Задача "Дни недели"///////////////////////////////////////////////

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

// Можно сделать через SWITCH CASE*************************************************************

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

////////////////////////////////////////////////Задача на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.//////////////

// System.Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// for (int i = -num; i <= num; i++)
// {
//     System.Console.Write(i + " ");
// }

//////////////////////////////////////////////Задача "вход трёхзначное число и на выходе показывает последнюю цифру этого числа"//////////////////////////////////////

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



////////////////////////////////////////////////////////  Семинар № 2 ///////////////////////////////


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

Random rand = new Random();
int num = rand.Next(100, 1000);
System.Console.WriteLine($"Случайное число: {num}");

System.Console.WriteLine($"{num / 100}{num % 10}");