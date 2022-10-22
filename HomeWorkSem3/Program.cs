// Задача №1 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*

bool Polindrome(int number)
{
    if(number/10000 == number%10)
    {
        if((number/1000)%10 == (number%100)/10)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    else
    {
        return false;
    }
    
}
Console.WriteLine("Здравствуй пользователь, эта программа проверяет является ли введенное тобой число полиндромом");
Console.Write("Введите пятизначное число: ");
int number5 = Convert.ToInt32(Console.ReadLine());
if(number5<0)
{
    number5=(-1)*number5;
}
if(number5>9999 && number5<100000)
{
    if(Polindrome(number5) == true)
    {
        Console.WriteLine("Число является полиндромом");
    }
    else
    {
        Console.WriteLine("Число не является полиндромом");
    }
}
else
{
    Console.WriteLine("Число не пятизначное");
}

*/

// Задача №2 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*

double RangeHipo3d(int coorX1, int coorY1, int coorZ1, int coorX2, int coorY2, int coorZ2)
{
    double AB = Math.Sqrt(Math.Pow((coorX2-coorX1), 2)+Math.Pow((coorY2-coorY1), 2)+Math.Pow((coorZ2-coorZ1), 2));
    return AB;
}

Console.WriteLine("Здравствуй пользователь, эта программа находит расстояние между точками в 3d пространстве");
Console.WriteLine("Введите 3D кординаты для точки A и для точки B:");
Console.Write("Введите X1 для точки A ");
int coorX1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y1 для точки A ");
int coorY1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z1 для точки A ");
int coorZ1 = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите X2 для точки B ");
int coorX2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y2 для точки B ");
int coorY2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z2 для точки B ");
int coorZ2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A({coorX1},{coorY1},{coorZ1})    B({coorX2},{coorY2},{coorZ2})");

double res = Math.Round(RangeHipo3d(coorX1, coorY1, coorZ1, coorX2, coorY2, coorZ2), 3);
Console.WriteLine($"Отрезок равен - {res} ");

*/


// Задача №3 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void CubeLine(int num)
{
    double i= 1;
    double cube = 1;
    while(i<=num)
    {
       cube = Math.Pow(i,3);
       Console.Write($"{cube} ");
       i++;
    }
}

Console.WriteLine("Здравствуй пользователь, эта программа возводит числа в куб");
Console.Write("Введите число от 1 до N <до которого будут отображаться последовательно кубы чисел>: ");
int numCube = Convert.ToInt32(Console.ReadLine());
if(numCube<0)
{
    numCube=(-1)*numCube;
}
if(numCube == 0)
{
    Console.WriteLine("Число не правильное");
}
CubeLine(numCube);

*/