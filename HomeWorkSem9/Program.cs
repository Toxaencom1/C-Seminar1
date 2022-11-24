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
ShowNumbers(n);
*/

// Задача №2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
Console.Clear();

Console.WriteLine("Здравствуй пользователь, эта программа которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии!");
int SummN(int m, int n)
{
    if (m == n)
        return n;
    else if (m > n)    
        return SummN(m - 1, n) + m;
    else 
        return SummN(m, n - 1) + n;
}

Console.WriteLine("Введите M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите N");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма натуральных чисел равна: {SummN(m, n)}");

*/





















// Задача №3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
