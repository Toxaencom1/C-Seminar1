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
