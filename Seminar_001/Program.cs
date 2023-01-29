System.Console.Write("Введите число: "); // 
int num = Convert.ToInt32(Console.ReadLine());// (int.Parse() || Convert.ToInt32() - конвертирование строки) - ввод данных пользователем
int res = num * num;
System.Console.WriteLine("Квадрат числа равен: " + res + " Text");
System.Console.WriteLine($"Квадрат числа равен: {res} Text");
