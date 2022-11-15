// Задача №1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 

// Задача №1. Вариант №1. Без массива (С помощью клавиш, бесконечный ввод от пользователя)

/*
int CheckNumberForCount(int num, bool parseResult)
{    
    if(parseResult)
    {
        Console.WriteLine("Число корректное, продолжайте...");
        if(num>0)            
            return 1;
        else       
            return 0;               
    }
    else
    {        
        Console.WriteLine("Число неверное, введите снова");        
        return 0;                   
    }    
}

void CheckNumberCountForOutput(int ruCount)
{    
    if(ruCount == 1 || (ruCount/10 >= 2 & ruCount%10 == 1))
        Console.WriteLine($"Вы ввели <{ruCount}> число больше 0");
    else if(ruCount == 2 || (ruCount/10 >= 2 & ruCount%10 == 2))
        Console.WriteLine($"Вы ввели <{ruCount}> числа больше 0");
    else if(ruCount == 3 || (ruCount/10 >= 2 & ruCount%10 == 3))
        Console.WriteLine($"Вы ввели <{ruCount}> числа больше 0");
    else if(ruCount == 4 || (ruCount/10 >= 2 & ruCount%10 == 4))
        Console.WriteLine($"Вы ввели <{ruCount}> числа больше 0");
    else
        Console.WriteLine($"Вы ввели <{ruCount}> чисел больше 0");
}

Console.WriteLine("Здравствуй пользователь, эта программа считает сколько чисел больше 0 вы ввели");

int count = 0;

ConsoleKeyInfo keyPress = new ConsoleKeyInfo();

do 
{
    Console.WriteLine("\nНажмите <Enter> чтобы ввести число или Нажмите клавишу <ESC> чтобы закончить вводить числа.");
    
    while (Console.KeyAvailable == false)
        Thread.Sleep(250); 
    keyPress = Console.ReadKey(true);        

    if(keyPress.Key == ConsoleKey.Enter)
    {
        Console.Write($"<{keyPress.Key}>, Введите число: ");
        int numbers;        
        bool result = int.TryParse(Console.ReadLine(), out numbers);
        count = count + CheckNumberForCount(numbers, result);
        CheckNumberCountForOutput(count);
    }
    else if(keyPress.Key == ConsoleKey.Escape)
        Console.Write($"Вы нажали клавишу '{keyPress.Key}', Вы закончили вводить числа\n");    
    else    
        Console.WriteLine("Пожалуйста, Нажмите только <Enter> для ввода или <Esc> для завершения");
    
} while(keyPress.Key != ConsoleKey.Escape);

CheckNumberCountForOutput(count);
*/

//-------------------------------------------------------------------------------------------------
// Задача №1. Вариант №2. С массивом

/*
void ArrayOutput(int[] array) 
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)    
        if(i == (array.Length-1))
            Console.Write($"{array[i]}");        
        else        
            Console.Write($"{array[i]}, ");
    Console.WriteLine("]");
}


int[] ArrayManualInput(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {(i+1)}й элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

Console.WriteLine("Здравствуй пользователь, эта программа считает сколько чисел больше 0 вы ввели");
Console.WriteLine("Введите количество чисел для ввода");
int count = 0;

int size = Convert.ToInt32(Console.ReadLine());
if(size<0)
    size *=(-1);

int[] myArray = new int[size];
myArray = ArrayManualInput(myArray);
ArrayOutput(myArray);

for (int i = 0; i < myArray.Length; i++)
{
    if(myArray[i]>0)    
        count ++;    
}
if(count < 5)            
    Console.Write($"Вы ввели <{count}> числа больше 0\n"); 
else
    Console.Write($"Вы ввели <{count}> чисел больше 0\n"); 
*/

// Задача №2. Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

/*
Console.WriteLine("Здравствуй пользователь, эта программа Находит точку пересечения двух прямых заданных уравнениями");
Console.WriteLine("y = k1 * x + b1, y = k2 * x + b2");

Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

if(k1 == k2 && b1 == b2)
    Console.WriteLine("Линии совпадают");
else if(k1 == k2)
    Console.WriteLine("Линии параллельны");
else
{
    double x = Math.Round((b2-b1)/(k1-k2), 3);
    double y = Math.Round(k1*((b2-b1)/(k1-k2))+b1, 3);
    Console.WriteLine($"Точка пересечения прямых - [{x};{y}]");
}
*/