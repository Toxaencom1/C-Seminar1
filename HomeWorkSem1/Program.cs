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



