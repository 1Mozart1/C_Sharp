/////  ЗАДАЧА № 1 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Random rand = new Random();
// int num = rand.Next(100, 1000);
// System.Console.WriteLine($"Случайное число: {num}");

// int num1 = num / 10;  
// int res = num1 % 10;

// System.Console.WriteLine($"Вторая цифра {res}");


/////  ЗАДАЧА № 2 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

while (num > 999 || num < -999)
{
    num = num / 10;
}
if (num > 99 & num < 1000 || num < -99)
{
    System.Console.WriteLine($"Третье число : {num % 10}");
}
else
{
    System.Console.WriteLine($"Нет третьего цифры");
}
