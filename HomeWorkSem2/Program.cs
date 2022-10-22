// Задача №1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.WriteLine("Здравствуй пользователь, эта программа показывает вторую цифру трёхзначного числа");

int SecondNumber(int number)
{
    int res = (number / 10)%10; 
    return res;
}

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
if(num>=100 && num<1000)
{
    int result = SecondNumber(num);
    Console.WriteLine($"{result} - ваша вторая цифра");
}
else
{
    Console.WriteLine("Число не является трехзначным");
}
*/

/*
// Задача №2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Здравствуй пользователь, эта программа выводит третью цифру заданного числа");

int ThirdNumber(int number)
{
    int index=0;
    int res=0;
    while(index<7)
    {
        if(number>99 && number<1000)
        {
            res = number%10;
            break;
        }
        else
        {
            number = number/10;
        }
        index++;
    }
    return res;
}

Console.WriteLine("Введите число:  P.S - не более 9 знаков ");
int num = Convert.ToInt32(Console.ReadLine());
if(num<0)
    {
        num = (-1)*num;
    }
if(num<100)
{
    Console.WriteLine("Число двузначное, третьей цифры нет!");        
}
else
{
    
    int result = ThirdNumber(num);
    Console.WriteLine($"{result} - ваша третья цифра");    
}
*/

/*
// Задача №3.  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Здравствуй пользователь, эта программа проверяет, является ли день выходным");

bool Holiday(int day)
{
    if(day == 6 || day == 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Введите цифру сответсвтующию дню недели от 1 до 7 соотвественно");
int days = Convert.ToInt32(Console.ReadLine());
if(days<1 || days>7)
{
    Console.WriteLine("Вы ввели не верную цифру");   
}
else
{
    bool result = Holiday(days);
    if(result == true)
    {
        Console.Write("Да");
    }
    else
    {
        Console.Write("Нет");
    }
}
*/