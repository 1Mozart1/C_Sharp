// System.Console.Write("Введите число: "); // 
// int num = Convert.ToInt32(Console.ReadLine());// (int.Parse() || Convert.ToInt32() - конвертирование строки) - ввод данных пользователем

// int res = num * num;

// System.Console.WriteLine("Квадрат числа равен: " + res + " Text");
// System.Console.WriteLine($"Квадрат числа равен: {res} Text");

// Задача: является ли число a, квадратом числа b ///////////////////////////////////////////////////// 

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

System.Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if(day == 1)
{
    System.Console.WriteLine("Понедельник");
}
else if(day == 2)
{
System.Console.WriteLine("Вторник");
}
else if(day == 3)
{
System.Console.WriteLine("Среда");
}
else if(day == 4)
{
System.Console.WriteLine("Четверг");
}
else if(day == 5)
{
System.Console.WriteLine("Пятница");
}
else if(day == 6)
{
System.Console.WriteLine("Суббота");
}
else if(day == 7)
{
System.Console.WriteLine("Воскресенье");
}
else 
{
System.Console.WriteLine("Такого дня нет");
}
