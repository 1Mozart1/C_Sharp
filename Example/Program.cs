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

Console.Clear();

int xa = 40, ya = 1, 
    xb = 1, yb = 20, 
    xc = 80, yc = 20;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;

int count = 0;

while (count < 10);
{
    int what = new Random().Next(0, 3);
    if (what == 0);
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1);
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
        if (what == 2);
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;    //
}

