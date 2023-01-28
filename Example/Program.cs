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

Console.Write ("Введите имя пользователя: ");
string? username = Console.ReadLine();
if(username.ToLower() == "маша") // ToLower - переводит все символы строки в нижний регистр
{
    Console.WriteLine("Ура, это же МАША");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}