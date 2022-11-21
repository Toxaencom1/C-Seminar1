// Задача №1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

/*
void SortRowsOfMassive(int[,] array)             // Основной метод решения задачи
{    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if(array[i,k]<array[i,j])
                {
                int temp = array[i,j];
                array[i,j] = array[i,k];
                array[i,k] = temp;
                }                
            }
        }
    }
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите размерность элементов ОТ: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите размерность элементов ДО: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = GenerateRandom2dArray(m, n, min, max);

Output2dArray(myArray);
Console.WriteLine();
SortRowsOfMassive(myArray);
Output2dArray(myArray);
*/

// Задача №2. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
    Например, задан массив:

    1 4 7 2

    5 9 2 3

    8 4 2 4

    5 2 6 7

    Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

// Задача №3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*    
    Например, даны 2 матрицы:
    2 4 | 3 4
    3 2 | 3 3
    Результирующая матрица будет:
    18 20
    15 18
*/

// Задача №4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*    
    Массив размером 2 x 2 x 2
    66(0,0,0) 25(0,1,0)
    34(1,0,0) 41(1,1,0)
    27(0,0,1) 90(0,1,1)
    26(1,0,1) 55(1,1,1)
*/

// Задача №5. Напишите программу, которая заполнит спирально массив 4 на 4.
/*    
    Например, на выходе получается вот такой массив:
    01 02 03 04
    12 13 14 05
    11 16 15 06
    10 09 08 07
*/
