// Задача №1 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 12321

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
Console.Write("Ввдеди пятизначное число: ");
int number5 = Convert.ToInt32(Console.ReadLine());
if(number5<0)
{
    number5=(-1)*number5;
}
if(number5>1 && number5<100000)
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

// Задача №3 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.