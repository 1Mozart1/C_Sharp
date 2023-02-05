///// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// System.Console.Write("Введите пятизначное число: ");
// string a = Console.ReadLine(); // Convert.ToInt32
// int num = a.Length;

// if (num == 5)
// {
//     if (a[0] == a[4] & a[1] == a[3])
//     {
//         System.Console.WriteLine($"{a} Число является палиндромом");
//     }
//     else
//     {
//         System.Console.WriteLine($"{a} Число не является палиндромом ");
//     }
// }
// else
// {
//     System.Console.WriteLine("Введено не пятизначное число");
// }




///// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// int input_num(string str)
// {
//     System.Console.Write(str);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int x1 = input_num("Введите координату x1: ");
// int y1 = input_num("Введите координату y1: ");
// int z1 = input_num("Введите координату z2: ");
// int x2 = input_num("Введите координату x2: ");
// int y2 = input_num("Введите координату y2: ");
// int z2 = input_num("Введите координату z2: ");

// double distance = (Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)), 3));
// System.Console.WriteLine($"Расстояние между точками  {distance}");




///// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// System.Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// for (int count = 1; count <= a; count++)
// {
//     System.Console.Write(Math.Pow(count, 3) + ", ");
// }