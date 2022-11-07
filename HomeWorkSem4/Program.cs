// Задача №1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

/*
int SquareNumber(int aNum, int bNum)
{
    int result = aNum;
    for (int count = 1;count < bNum; count++)  
    {
        result *= aNum;
    }
    return result;
}

Console.WriteLine("Привет пользователь, эта программа возводит число А в число В: Введите число А");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи число В: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a==0 & b ==0)
{
    Console.WriteLine("Задача с такими параметрами не имеет смысла (((");
}
else
{
    if(b<0)
    {
        b= b*(-1);
    }

    if(b == 0)
    {
        Console.WriteLine($"{a} в степени {b} равно: 1 ");
    }
    else
    {
        Console.WriteLine($"{a} в степени {b} равно: {SquareNumber(a,b)}");
    }
}
*/



// Задача №2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 

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
if(num < 0)
{
    num = num * (-1);
}
Console.WriteLine($"Сумма знаков вашего числа равна: {SymbolsSum(num)}");

*/


// Задача №3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*
void ArrayOutput(int[] array)
{
    Console.Write("[");
    for (int j = 0; j < array.Length; j++)
    {
        if(j == (array.Length-1))
        {
            Console.Write($"{array[j]}");   
        }
        else
        {
            Console.Write($"{array[j]}, ");    
        }
    }
    Console.Write("]");
}

int[] ArrayRandomInput(int[] myArray)
{
    for (int k = 0; k < myArray.Length; k++)
        {
            myArray[k] = new Random().Next(1,100);
        }
    return myArray;
}    

Console.WriteLine("Привет пользователь, эта программа показывает методы ввода массива и его вывод");
Console.WriteLine("Первый метод ввода - ввод с клавиатуры");
Console.WriteLine("Введите 8 элементов массива по очереди: ");
int[] array  = new int[8];  
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {(i+1)}й элемент массива");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();
ArrayOutput(array);
Console.WriteLine("\n");


Console.WriteLine("А еще можно заполнять массивы случайными числами например от 1го до 100");
Console.WriteLine("Введите число случайных массивов для демонстрации");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вот например: {n} массивов заполненых случайными числами" + "\n");

int[] myArray  = new int[8];
int count = 0;
while(count < n)
{
    ArrayRandomInput(myArray);
    ArrayOutput(myArray);
    Console.WriteLine("\n");
    count++;
}

Console.WriteLine("\n");
*/






