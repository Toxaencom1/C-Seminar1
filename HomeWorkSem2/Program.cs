// Задача №1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.WriteLine("Здравствуй пользователь, эта программа показывает вторую цифру трёхзначного числа");

int SecondNumber(int number)
{
    int res = (number / 10)%10; 
    return res;
}

Console.WriteLine("Введи трехзначное число");
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
        if(number>100 && number<1000)
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

Console.WriteLine("Введи число:  P.S - не более 9 знаков ");
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
