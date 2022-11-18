// Домашнее задание по седьмому семинару
// Задача №1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
void Double2dArrayOutput(double[,] array)  // вывести Двумерный массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0}\t",array[i, j]);
        }
        Console.WriteLine(" ]");
    }
}

double[,] GenerateDoubleRandom2dArray(int rows, int columns, int minValue, int maxValue) //основной метод для решения задачи
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);            
            array[i, j] += new Random().NextDouble();                                     
            array[i, j] = Math.Round(array[i, j], 1);            
        }
    return array;
}
Console.WriteLine("Здравствуй пользователь, эта программа выводит двумерный массив случайных вещественных чисел");
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите размерность элементов ОТ: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите размерность элементов ДО: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = GenerateDoubleRandom2dArray(m, n, min, max);

Double2dArrayOutput(myArray);
*/

// Задача №2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
int[,] GenerateRandom2dArray(int rows, int columns, int minValue, int maxValue) // Заполнить двумерный массив
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Output2dArray(int[,] array)                              // Вывести двумерный массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0}\t", array[i, j]);
        }
        Console.WriteLine(" ]");
    }
}

void Show2dMassiveElement(int[,] array, int rows, int columns)         // Основной метод для решения задачи
{
    if (rows > array.GetLength(0) || columns > array.GetLength(1))
    {
        Console.WriteLine("Такого элемента не существует"+"\nПопробуйте снова, вам обязательно повезет");
    }
    else
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
                if (rows == i && columns == j)
                    Console.WriteLine($"Ваш элемент {array[i-1, j-1]}"); // Значения сделаны для удобства пользователя

}
Console.WriteLine("Здравствуй пользователь, эта программа покажет вам значение элемента <случайного> двумерного массива");
Console.WriteLine("Давайте зададим координаты элемента которого хотим увидеть");
Console.Write("Задайте строку элемента массива : ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте столбец элемента массива : ");
int column = Convert.ToInt32(Console.ReadLine());


int[,] myArray = GenerateRandom2dArray(new Random().Next(2, 15), new Random().Next(2, 15), -100, 100);
Console.WriteLine();
Output2dArray(myArray);
Console.WriteLine();
Show2dMassiveElement(myArray, row, column);
Console.WriteLine();
*/

// Задача №3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*
void Double2dArrayOutput(double[,] array)  // вывести Двумерный массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write("{0}\t", array[i, j]);
        Console.WriteLine(" ]");
    }
}

void DoubleArrayOutput(double[] array) // вывести одномерный массив
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        if (i == (array.Length - 1))
            Console.Write($"{array[i]}");
        else
            Console.Write($"{array[i]}\t");
    Console.WriteLine("]");
}

double[,] FillDoubleRandom2dArray(int rows, int columns, int minValue, int maxValue) //заполнить двумерный массив
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

double[] ColumnElementsAverageValue(double[,] array, double[] avgMassive) // Основной метод для решения задачи
{
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            sum += array[i, j];
        avgMassive[j] = Math.Round(sum / array.GetLength(0), 2);
        sum = 0;
    }
    return avgMassive;
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите размерность элементов ОТ: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите размерность элементов ДО: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] my2dArray = FillDoubleRandom2dArray(m, n, min, max);

double[] avgMassive = new double[my2dArray.GetLength(1)];

Double2dArrayOutput(my2dArray);
ColumnElementsAverageValue(my2dArray, avgMassive);
Console.WriteLine();
DoubleArrayOutput(avgMassive);
*/