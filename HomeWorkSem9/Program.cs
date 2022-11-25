// Задача №1.   Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

/*
void ShowNumbers(int n)
{
    Console.Write(n + " ");       
    if (n > 1) ShowNumbers(n - 1);
}

Console.Clear();

Console.WriteLine("Здравствуй пользователь, эта программа выводит все натуральные числа в промежутке от N до 1 с помощью рекурсии!");
Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n<0)
{
Console.WriteLine("Отрицательные числа не являются натуральными, меняю знак");
n*=(-1);
} 
ShowNumbers(n);
*/


// Задача №2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
Console.Clear();

Console.WriteLine("Здравствуй пользователь, эта программа которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии!");
int SumOfNaturalElements(int m, int n)
{
    if (m == n)
        return n;
    else if (m > n)    
        return SumOfNaturalElements(m - 1, n) + m;
    else 
        return SumOfNaturalElements(m, n - 1) + n;
}

Console.WriteLine("Введите M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите N");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма натуральных чисел равна: {SumOfNaturalElements(m, n)}");
*/


// Задача №3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/*
uint AckermanFunction(uint m, uint n)
{
    if (m == 0)
        return n + 1;
    else if (m != 0 && n == 0)
        return AckermanFunction(m - 1, 1);
    else
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}

Console.Clear();

Console.WriteLine("Здравствуй пользователь, эта программа вычисления функции Аккермана с помощью рекурсии");
Console.WriteLine("Введите положительные числа M и N");

Console.WriteLine("Введите M");
uint m = Convert.ToUInt32(Console.ReadLine());

Console.WriteLine("Введите N");
uint n = Convert.ToUInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"Вычисление функции Аккермана равны: {AckermanFunction(m, n)}");
*/