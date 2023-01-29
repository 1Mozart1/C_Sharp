////////////////////////////////// Задача "какое число большее, а какое меньшее" ////////////////////////////

// System.Console.Write("Введите число а: ");
// int num_A = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите число b: ");
// int num_B = Convert.ToInt32(Console.ReadLine());

// if (num_A > num_B)
// {
//     System.Console.WriteLine("Число A больше " + num_A);
// }
// else
// {
//     System.Console.WriteLine("Число B больше " + num_B);
// }


////////////////////////////////// Задача "максимальное из 3-х чисел." ////////////////////////////////////

// System.Console.Write("Введите число а: ");
// int num_A = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите число b: ");
// int num_B = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите число c: ");
// int num_C = Convert.ToInt32(Console.ReadLine());

// int max = num_A;

// if (num_B > max) max = num_B;
// if (num_C > max) max = num_C;

// System.Console.WriteLine("Максимальное число " + max);

/////////////////////////////////// Задача "является ли число четным" //////////////////////////////////////

// System.Console.Write("Введите число : ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num % 2 == 0)
// {
//     System.Console.WriteLine("Число четное");
// }
// else
// {
//     System.Console.WriteLine("Число нечетное");
// }

//////////////////////////////////// Задача "все четный числа до введеного числа"///////////////////////////

System.Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= num; i+=2)
{
    System.Console.Write(i + " ");
}