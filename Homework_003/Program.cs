












///// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

for (int count = 1; count <= a; count++)
{
    System.Console.Write(Math.Pow(count, 3) + ", ");
}