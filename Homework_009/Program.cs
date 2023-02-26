// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Metka:
// int Input(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int Sum(int m, int n)
// {
//     if (n > m) return m + Sum(m + 1, n); ;
//     return m;
// }
// int m = Input("Введите число M: ");
// int n = Input("Введите число N: ");

// if (n <= m)     // проверка
// {
//     //(m, n) = (n, m);

//     // ИЛИ

//     System.Console.WriteLine("Нет промежутка между M и N");
//     goto Metka;
// }

// System.Console.WriteLine($"Сумма чисел от {m} до {n} = {Sum(m, n)}");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 

int Input(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int FunctionA(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return FunctionA(m - 1, 1);
    else return FunctionA(m - 1, FunctionA(m, n - 1));
}
int m = Input("Введите число M: ");
int n = Input("Введите число N: ");

System.Console.WriteLine(FunctionA(m, n));