// Console.Write("Введите ваше имя: "); 
// string username = Console.ReadLine (); // введение данных пользователем
// Console.Write("Привет, ");
// Console.WriteLine(username);

// int numA = 31;
// int numВ = 5;
// int res = numA + numВ;
// Console.WriteLine(res);

// double numA = 31; // тип данных, который используется для переменных, содержащих числа с дробной частью
// double numB = 15;
// double res = (numA / numB);
// Console.WriteLine(res);

// int numA = new Random().Next(-100,100); // рамдомное число
// int numB = new Random().Next(-100,100);
// int res = numA * numB;
// Console.WriteLine(res);

// int numA = new Random().Next(-100,100);
// Console.WriteLine(numA);                // что бы видеть рандомные числа
// int numB = new Random().Next(-100,100);
// Console.WriteLine(numB);
// int res = numA * numB;
// Console.WriteLine(res);

// Console.Write ("Введите имя пользователя: ");
// string? username = Console.ReadLine();
// if(username.ToLower() == "маша") // ToLower - переводит все символы строки в нижний регистр
// {
//     Console.WriteLine("Ура, это же МАША");
// }
// else
// {
//     Console.Write("Привет, ");
//     Console.WriteLine(username);
// }

///////////////////////////////////////////////  Рисование  ///////////////////////////////////////////////

// Console.Clear();

// int xa = 40, ya = 1, 
//     xb = 1, yb = 20, 
//     xc = 80, yc = 20;

// Console.SetCursorPosition(xa, ya);
// Console.WriteLine("+");

// Console.SetCursorPosition(xb, yb);
// Console.WriteLine("+");

// Console.SetCursorPosition(xc, yc);
// Console.WriteLine("+");

// int x = xa, y = xb;

// int count = 0;

// while (count < 10000)
// {
//     int what = new Random().Next(0, 3);
//     if (what == 0)
//     {
//         x = (x + xa) / 2;
//         y = (y + ya) / 2;
//     }

//     if (what == 1)
//     {
//         x = (x + xb) / 2;
//         y = (y + yb) / 2;
//     }

//     if (what == 2)
//     {
//         x = (x + xc) / 2;
//         y = (y + yc) / 2;
//     }

//     Console.SetCursorPosition(x, y);
//     Console.WriteLine("+");
//     count++;    // тоже самое count = count + 1, или count += 1
// }

//********************************************************  Лекция 2  ******************************************************


// int Max(int arg1, int arg2, int arg3) ---------- ФУНКЦИЯ -------
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }----------------------------------------------- ФУНКЦИЯ -------

// int a1 = 11;
// int b1 = 15;
// int c1 = 70;
// int a2 = 19;
// int b2 = 85;
// int c2 = 30;
// int a3 = 177;
// int b3 = 55;
// int c3 = 39;

// // int max1 = Max(a1, b1, c1);
// // int max2 = Max(a2, b2, c2);
// // int max3 = Max(a3, b3, c3);
// // int max = Max(max1, max2, max3);

// // ИЛИ ТАК

// int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

// System.Console.WriteLine(max);

///////////////////////////////////////////////////////// МАССИВ /////////

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int[] array = { 1, 15, 84, 6, 41, 63, 47, 58, 99 }; // МАССИВ

// int max = Max(Max(array[0], array[1], array[2]),
//           Max(array[3], array[4], array[5]),
//           Max(array[6], array[7], array[8]));
// System.Console.WriteLine(max);


//////////////////////////////////////////////////////// Поиск индекса массива //////////////////////////////

// int[] array = { 1, 15, 84, 99, 41, 63, 47, 58, 99 };

// int n = array.Length;  // длина массива

// int find = 99;   // ищем индекс массива

// int index = 0;

// while (index < n)
// {
//     if (array[index] == find)
//     {
//         System.Console.WriteLine(index);
//         break;                           // прерывает поиск, ищет до первого элемента
//     }
//     index++;
// }

/////////////////////////////////////////////////////// Массив любой величины ///////////////////////////////////

// void - не возвращает значения

// void FillArray(int[] collection) // создаёт массив

// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index++;
//     }

// }

// void PrintArray(int[] col) // Печатает массив
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         System.Console.WriteLine(col[position]);
//         position++;
//     }
// }

// int IndexOf(int[] collection, int find)
// {
//     int count = collection.Length;
//     int index = 0;
//     int position = -1; // указываем -1 для того чтобы показывал несуществующий элемент
//     while (index < count)
//     {
//         if (collection[index] == find)
//         {
//             position = index;
//             break;
//         }
//         index++;
//     }
//     return position;
// }

// int[] array = new int[10]; // указываем количество элементов в массиве

// FillArray(array); // заполняет массив
// PrintArray(array); // выводит на экран созданный массив
// System.Console.WriteLine();

// int pos = IndexOf(array, 14);
// System.Console.WriteLine(pos);


//********************** Lesson # 3 *************************************************************************************

// Виды методов

// 1 группа (ничего не принимаю и ничего не возвращают)**********************************

//void Method1() // void- имя метода, потом название
// {
//     System.Console.WriteLine("Автор ...");
// }
//Method1(); // скобки обязательно


// 2 группа (ничего не возвращают, но могут принимать данные)******************************

//void Method2(string msg)
// {
//     System.Console.WriteLine(msg);
// }
//Method2(msg: "Текст");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         System.Console.WriteLine(msg);
//         i++;
//     }

// }
//Method21("Текст", 4);
//Method21(msg: "Текст", count: 4);  // можно присваивать конкретному значению
//Method21(count: 4, msg: "Текст" ); // необязательно по порядку


// 3 группа (что-то возвращают, но ничего не принимают)*******************************

// int Method3()  // Обязательно должны указать тип данных
// {
//     return DateTime.Now.Year; // return - обязательно оператор возврата
// }
// int Year = Method3();
// System.Console.WriteLine(Year);


// 4 группа (что-то принимаю и что-то возвращают)*************************************

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty; // для начала должны быть хоть какае- нибудь значения, в данном случае "пустая строка" 

//     while (i < count)
//     {
//         result = result + text;    
//         i++;
//     }
//     return result;

// }
// string res = Method4(10, "z");
// System.Console.WriteLine(res);

// Через цикл FOR **************************************

// string Method4(int count, string text)
// {
//     string result = string.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;

// }
// string res = Method4(10, "z");
// System.Console.WriteLine(res);

// Цикл в Цикле - таблица уножения

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         System.Console.WriteLine($"{i} * {j} = {i*j}");
//     }
//     System.Console.WriteLine(""); // чтобы разделить строки
// }


// Задача Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы “к” заменить большими “К”, *****************
// а большие “В” заменить маленькими “в”.

// string s = "qwerty"
//             012345
// s[3] - r

// string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде, "
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Выдадите мне чаю? ";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = string.Empty;

//     int Length = text.Length;
//     for (int i = 0; i < Length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }


//     return result;
// }
// string newText = Replace(text, ' ', '|'); // указавыем где мы хотим заменить, что хотим заменитью на что хотим заменить
// System.Console.WriteLine(newText);

// System.Console.WriteLine();

// newText = Replace(newText, 'к', 'К');
// System.Console.WriteLine(newText);

// System.Console.WriteLine();

// newText = Replace(newText, 'В', 'в');
// System.Console.WriteLine(newText);


// Сортировка массива *******************************************

// int[] arr = { 1, 4, 6, 3, 2, 7, 5, 1, 1 };

// void PrintArray(int[] array) // новый массив
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
//     System.Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;

//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }

//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;

//     }
// }
// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);



//********************** Lesson # 4 *************************************************************************************


//int[,] matrix = new int[5, 8] // запятая в скобках говорит о том что это дыумерный массив. 1-я цифра это строки, 2-я цифра это столбцы

// string[,] table = new string[2,5];
// // String.Empty
// // table [0,0] table [0,1] table [0,2] table [0,3] table [0,4]
// // table [1,0] table [1,1] table [1,2] table [1,3] table [1,4]

// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++) // rows - строки
// {
//  for (int columns = 0; columns < 5; columns++) // columns - столбцы
//  {
//  Console.WriteLine($"-{table[rows, columns]}-");
//  }
// }


// int[,] matrix = new int[3, 4];
// for (int i = 0; i < matrix.GetLength(0); i++) // .GetLenght(0) - полчить длину массива (0) именно кол-во строк
// {
//     for (int j = 0; j < matrix.GetLength(1); j++) // .GetLenght(1) - (1) кол-во столбцов
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }

//**************************************************************

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);//[1; 10)
//         }
//     }
// }
// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

//********************************************************

// int[,] pic = new int[,] 
// {
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };

// void PrintImage(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             if (image[i, j] == 0) Console.Write($" ");
//             else Console.Write($"+");
//         }
//         Console.WriteLine();
//     }
// }
// void FillImage(int row, int col)
// {
//     if (pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         FillImage(row - 1, col);
//         FillImage(row, col - 1);
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);
//     }
// }
// PrintImage(pic);
// FillImage(13, 13);
// PrintImage(pic);

//******************************************************

// int Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// Console.WriteLine(Factorial(3)); // 1 * 2 * 3 = 6


// int Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1); // ПЕРЕПОЛНЕНИЕ ДАННЫХ ******************************************************
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine(Factorial(i));
// }


// double Factorial(int n)  // double хранит больше данных чем int
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }


// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)


// int Fibonacci(int n)
// {
//  if(n == 1 || n == 2) return 1;
//  else return Fibonacci(n-1) + Fibonacci(n-2);
// }
// for (int i = 1; i < 10; i++)
// {
//  Console.WriteLine(Fibonacci(i));
// }


// double Fibonacci(int n)
// {
//  if(n == 1 || n == 2) return 1;
//  else return Fibonacci(n-1) + Fibonacci(n-2);
// }
// for (int i = 1; i < 50; i++)
// {
//  Console.WriteLine(Fibonacci(i));
// }


//********************** Lesson # 7 РЕКУРСИЯ  *********************************************************************************


// string NumbersFor(int a, int b)
// {
//     string result = String.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }
// Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10

//         ИЛИ через РЕКУРСИЮ

// string NumbersRec(int a, int b)
// {
//  if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
//  else return String.Empty;
// }
// Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10

//-----------------------------------------------------------------------------------------

// string NumbersFor(int a, int b)
// {
//     string result = String.Empty;
//     for (int i = a; i >= b; i--)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }
// Console.WriteLine(NumbersFor(1, 10)); // 10 9 8 7 6 5 4 3 2 1

//      ИЛИ через РЕКУРСИЮ

// string NumbersRec(int a, int b)
// {
//     if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
//     else return String.Empty;
// }

// Console.WriteLine(NumbersRec(1, 10)); // 10 9 8 7 6 5 4 3 2 1

//--------------------------------------------------------------------------------------

// int SumFor(int n)
// {
//  int result = 0;
//  for (int i = 1; i <= n; i++) result += i;
//  return result;
// }
// Console.WriteLine(SumFor(10)); // 55

//      ИЛИ через РЕКУРСИЮ 

// int SumRec(int n)
// {
//  if (n == 0) return 0;
//  else return n + SumRec(n - 1);
// }
// Console.WriteLine(SumRec(10)); // 55

//----------------------------------------------------------------------------

// int FactorialFor(int n)
// {
//  int result = 1;
//  for (int i = 1; i <= n; i++) result *= i;
//  return result;
// }
// Console.WriteLine(FactorialFor(10)); // 3628800

//      ИЛИ через РЕКУРСИЮ 

// int FactorialRec(int n)
// {
//  if (n == 1) return 1;
//  else return n * FactorialRec(n - 1);
// }

// Console.WriteLine(FactorialRec(10)); // 3628800

//----------------------------------------------------------------------------

// int PowerFor(int a, int n)
// { int result = 1;
//  for (int i = 1; i <= n; i++) result *= a;
//  return result;
// }
// int PowerRec(int a, int n)
// { return n == 0 ? 1 : PowerRec(a, n - 1) * a;
//  if (n == 0) return 1;
//  else return PowerRec(a, n - 1) * a;
// }
// int PowerRecMath(int a, int n)
// {
//  if (n == 0) return 1;
//  else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
//  else return PowerRecMath(a, n - 1) * a;
// }
// Console.WriteLine(PowerFor(2, 10)); // 1024
// Console.WriteLine(PowerRec(2, 10)); // 1024
// Console.WriteLine(PowerRecMath(2, 10)); // 1024

//----------------------------------------------------------------------------

//Просмотр папок

// void CatalogInfo(string path, string indent = "")
// {
//  DirectoryInfo catalogs = new DirectoryInfo(path);
//  foreach (var currentCatalog in catalogs.GetDirectories())
//  {
//  Console.WriteLine($"{indent}{currentCatalog.Name}");
//  CatalogInfo(currentCatalog.FullName, indent + " ");
//  }
//  foreach (var item in catalogs.GetFiles())
//  {
//  Console.WriteLine($"{indent}{item.Name}");
//  }
// }
// string path = @"D:\Educatione";
// CatalogInfo(path);

//----------------------------------------------------------------------------

// Обход разных структур

// string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
// // 0 1 2 3 4 5 6 7 8 9 10 11
// void InOrderTraversal(int pos = 1)
// {
//  if (pos < tree.Length)
//  {
//  int left = 2 * pos;
//  int right = 2 * pos + 1;
//  if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
//  Console.WriteLine(tree[pos]);
//  if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
//  }
// }

