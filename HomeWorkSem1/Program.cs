// Серия задач из "Привет друг, эта программа..... "

// Задача №1 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.WriteLine("Привет друг, эта программа покажет какое число большее а какое меньшее");
Console.WriteLine("Введи первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Обрабатываю запрос ... ");
if(a>b)
{
    Console.WriteLine($"<{a}> - Большее число"); 
    Console.WriteLine($"<{b}> - Меньшее число");       
}
else
{
    Console.WriteLine($"<{b}> - Большее число"); 
    Console.WriteLine($"<{a}> - Меньшее число"); 
}
*/

//Задача №2  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.WriteLine("Привет друг, эта программа покажет максимальное число из 3х чисел которые ты введешь");
Console.WriteLine("Введи первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи третье число");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Обрабатываю запрос ... ");

int max;

if(a>b)
{
    max=a;
    if(max<c)
    {
        max=c;
    }
}
else
{
    max=b;
    if(max<c)
    {
        max=c;
    }
}
Console.WriteLine($"{max} - максимальное число");
*/

//Задача №3 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.WriteLine("Привет друг, эта программа покажет является ли число четным или нет");
Console.WriteLine("Введи число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Обрабатываю запрос ... ");
int even = a%2;

if(even == 0)
{
    Console.WriteLine("Ваше число ЧЁТНОЕ");
}
else
{
    Console.WriteLine("Ваше число НЕЧЁТНОЕ");    
}

*/

//Задача №4 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.WriteLine("Привет друг, эта программа покажет все четные числа от единицы до введeнного тобой числа");
Console.WriteLine("Введи число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Обрабатываю запрос ... ");
int numbers=1;
int even=numbers%2;

if(n>0)
{
    while(numbers<=n)
    {
        if(numbers%2 == 0)
        {
        Console.Write($"{numbers} ");
        }
    numbers++;
    }
}
else
{
    while(numbers>=n)
    {
        if(numbers == 0)
        {}
        else
        {
            if(numbers%2 == 0)
            {
                Console.Write($"{numbers} ");
            }
        }
        
    numbers--;
    }
}
*/