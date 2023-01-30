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
// Console.WriteLine(numA); // что бы видеть рандомные числа
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

void FillArray(int[] collection) // создаёт массив

{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArray(int[] col) // Печатает массив
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // указываем -1 для того чтобы показывал несуществующий элемент
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // указываем количество элементов в массиве

FillArray(array); // заполняет массив
PrintArray(array); // выводит на экран созданный массив
System.Console.WriteLine();

int pos = IndexOf(array, 14);
System.Console.WriteLine(pos);