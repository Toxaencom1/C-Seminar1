// Задача №1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

/*
int SquareNumber(int aNum, int bNum)
{
    int count = 1;
    int square = bNum;
    int result = aNum;
    while(count<square)
    {
        result *= aNum;
        count ++;
    }
    return result;
}

Console.WriteLine("Привет пользователь, эта программа возводит число А в число В: Введи число А");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи число В: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"А в степени В равна: {SquareNumber(a,b)}");
*/

// Задача №2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. (901)

/*
int SymbolsSum(int fullNumber)
{
    int lastNumber = 0;
    int count = 1;
    int result = 0;
    while(count != 0)
    {
        if(fullNumber == 0)
        {
            break;
        }
        else
        {
            lastNumber = fullNumber;
            lastNumber %= 10;
            result += lastNumber;
            fullNumber /= 10;
        }
        
    }
    return result;
}

Console.WriteLine("Привет пользователь, эта программа считает сумму всех знаков числа: Введи число не более 9и знаков");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма знаков вашего числа равна: {SymbolsSum(num)}");

*/




// Задача №3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.