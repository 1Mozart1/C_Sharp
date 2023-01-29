// System.Console.Write("Введите число: "); // 
// int num = Convert.ToInt32(Console.ReadLine());// (int.Parse() || Convert.ToInt32() - конвертирование строки) - ввод данных пользователем

// int res = num * num;

// System.Console.WriteLine("Квадрат числа равен: " + res + " Text");
// System.Console.WriteLine($"Квадрат числа равен: {res} Text");

// Задача: является ли число a, квадратом числа b 
System.Console.Write("Введите число а: ");
int num_A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число b: ");
int num_B = Convert.ToInt32(Console.ReadLine());

if (num_B * num_B == num_A)
{
    System.Console.WriteLine("Является квадратом числа");
}
else 
{
    System.Console.WriteLine("Не является квадратом числа");
}