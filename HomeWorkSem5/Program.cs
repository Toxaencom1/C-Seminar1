// Задача №1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.


/*
void ArrayOutput(int[] array) // P.S Общий метод для первой и второй задачи!!! Перегрузку методов делать не умеею пока, для 3й задачи отдельно методы
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)    
        if(i == (array.Length-1))
            Console.Write($"{array[i]}");        
        else        
            Console.Write($"{array[i]}, ");
    Console.WriteLine("]");
}



int[] ArrayRandomInput(int length, int a, int b) // Общий метод для первой и второй задачи!!! 
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)        
        array[i] = new Random().Next(a,b);
    return array;
}    
*/

/*
int EvenNumbersOfArrayCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)    
        if(array[i]%2 == 0)        
           count++;
    return count;
}


Console.WriteLine("Привет пользователь, эта программа считает количество случайных, четных, трехзначных элементов массива");
Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());

if(length<0)
    length = length * (-1);

int[] myArray = ArrayRandomInput(length, 100, 1000);
Console.WriteLine();
ArrayOutput(myArray);
Console.WriteLine($"\nЧисло четных элементов массива: {EvenNumbersOfArrayCount(myArray)} \n");
*/


// Задача №2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// P.S - Для задачи требуется метод выше ArrayOutput и ArrayRandomInput

/*
int SumOfUnevenValueIndex(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)    
        sum += array[i];    
    return sum;
}

Console.WriteLine("Привет пользователь, эта программа считает сумму случайных значений, нечетных позиций массива");
Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.Write("Введите размерность элементов массива ОТ: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность элементов массива ДО: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

if(length<0)
    length = length * (-1);

int[] myArray = ArrayRandomInput(length, a, b);
ArrayOutput(myArray);
Console.WriteLine($"\nСумма элементов массива на нечетных позициях равна: {SumOfUnevenValueIndex(myArray)}\n");
*/

// Задача №3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*
double[] ArrayDoubleRandomInput(int length)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
        {            
            array[i] = new Random().Next(-100,100);
            array[i] += new Random().NextDouble();
            array[i] = Math.Round(array[i], 2);
        }
    return array;
}    


double MaxMinDiff(double[] array)
{
    double minValue = array[0];
    double maxValue = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < minValue)        
            minValue = array[i];        
        if(array[i] > maxValue)        
            maxValue = array[i];        
    }
    double result = maxValue - minValue;
    return result; 
}

void ArrayOutputDouble(double[] array) 
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i == (array.Length-1))
            Console.Write($"{array[i]}");        
        else
            Console.Write($"{array[i]} ; ");
    }
    Console.WriteLine("]");
}

Console.WriteLine("Привет пользователь, эта программа считает разницу случайных вещественных значений,\nмежду минималным и максимальным значнением  массива");
Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());

if(length<0)
    length = length * (-1);

Console.WriteLine();

double[] myArray = ArrayDoubleRandomInput(length);
ArrayOutputDouble(myArray);
Console.WriteLine($"\nРазница между минимальным и максимальным равна: {Math.Round(MaxMinDiff(myArray),2)}\n");
*/