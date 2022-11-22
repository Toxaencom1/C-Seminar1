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

void ArrayOutput(int[] array) // вывести одномерный массив
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        if (i == (array.Length - 1))
            Console.Write($"{array[i]}");
        else
            Console.Write($"{array[i]}  ");
    Console.WriteLine("]");
}


/*

Console.Clear();

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

Console.WriteLine("Здравствуй пользователь, эта программа которая упорядочит по убыванию элементы каждой строки двумерного массива");

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

Console.Clear();

int MinSumRow(int[,] array) // Основной метод для решения задачи  
{
    int sum = 0;    
    int minSum = 0;
    int minSumFirst = 0;
    int minIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)        
            sum += array[i, j];               
        minSumFirst = sum;
        if (i == 0)
            minSum = minSumFirst;
        if (sum < minSum)
        {
            minSum = sum;
            minIndex = i;
        }
        sum = 0;
    }
    return minIndex + 1;
}


Console.WriteLine("Здравствуй пользователь, эта программа которая будет находить строку с наименьшей суммой элементов");

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


Console.WriteLine($"<{MinSumRow(myArray)}я> - строка имеет минимальное значение суммы её элементов");
*/


// Задача №3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*
Console.Clear();

int[,] MatrixMultiply(int[,] arrayK, int[,] arrayL)
{
    int[,] arrayKL = new int[arrayK.GetLength(0), arrayL.GetLength(1)];
    if (arrayK.GetLength(1) == arrayL.GetLength(0))
    {
        for (int i = 0; i < arrayK.GetLength(0); i++)
        {
            for (int j = 0; j < arrayL.GetLength(0); j++)
            {
                for (int k = 0; k < arrayL.GetLength(1); k++)
                {
                    arrayKL[i, k] += arrayK[i, j] * arrayL[j, k];
                }
            }
        }
    }
    else Console.WriteLine("Умножение невозможно, нужно чтобы количество столбцов первой матрицы совпадало с количеством строк другой");
    return arrayKL;
}
Console.WriteLine("Здравствуй пользователь, эта программа которая будет находить произведение двух матриц");

Console.Write("Введите количество строк для матрицы K: ");
int m1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов для матрицы K: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк для матрицы L: ");
int m2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов для матрицы L: ");
int n2 = Convert.ToInt32(Console.ReadLine());



int[,] myArrayK = GenerateRandom2dArray(m1, n1, 0, 9);
int[,] myArrayL = GenerateRandom2dArray(m2, n2, 0, 9);
Output2dArray(myArrayK);
Console.WriteLine();
Output2dArray(myArrayL);
Console.WriteLine();
Output2dArray(MatrixMultiply(myArrayK, myArrayL));
*/

// Задача №4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.

/*

Console.Clear();

int[,,] GenerateRandom3dArray(int page, int rows, int columns, int minValue, int maxValue) // Заполнить трехмерный массив
{
    int[,,] array = new int[page, rows, columns];
    int[] arrayFill = new int[array.Length];
    
    bool isUniq;
    arrayFill[0] = new Random().Next(10, 100);
    for (int i = 1; i < arrayFill.Length; i++)
    {
        arrayFill[i] = new Random().Next(10,100);
        for (int j = i; j >= 1; j--)
        {
            do
            {                
                if(arrayFill[i-j]==arrayFill[i] )
                {
                    isUniq = false;
                    j = i;
                    arrayFill[i] = new Random().Next(10,100);
                }
                else
                {
                    isUniq = true;
                }
            } while (!isUniq);
        }        
    }
    for (int i = 0, l =0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++,l++)
            {
                array[i,j,k] = arrayFill[l];
            }
        }
    }    
    return array;
}

void Output3dArray(int[,,] array)                              // Вывести трехмерный массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"Страница {i + 1}");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("[ ");
            for (int k = 0; k < array.GetLength(2); k++)
        /   {
                Console.Write($"{array[i, j, k]}({i},{j},{k})\t");
            }
            Console.WriteLine(" ]");
        }
    }
}
Console.WriteLine("Здравствуй пользователь, эта программа формирует трёхмерный массив из неповторяющихся двузначных чисел");

Console.Write("Введите количество страниц: ");
int l = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

if(!(l*m*n>90))
{
    int[,,] MyFirst3dAraay = GenerateRandom3dArray(l, m, n, 10, 99);    
    Output3dArray(MyFirst3dAraay);
}
else
{
 Console.WriteLine("Уникальных двухзначных чисел недостаточно, чтобы заполнить массив таких размеров");
}
*/


// Задача №5. Напишите программу, которая заполнит спирально массив 4 на 4.

/*
Console.Clear();

int[,] GenerateCount2dArrayHelix(int rows, int columns) // Заполнить двумерный массив последовательными числами по спирали
{
    int count = 1;
    int[,] array = new int[rows, columns];

    for (int l = 0; l < array.GetLength(0) / 2 && l < array.GetLength(1) / 2; l++)
    {
        for (int i = 0 + l; i < 1 + l; i++)
            for (int j = 0 + l; j < array.GetLength(1) - l; j++, count++)  //вправо
                array[i, j] = count;

        for (int i = 0 + 1 + l; i < array.GetLength(0) - l; i++)
            for (int j = array.GetLength(1) - 1 - l; j <= array.GetLength(1) - 1 - l; j++, count++) //Вниз
                array[i, j] = count;

        for (int i = array.GetLength(0) - 1 - l; i <= array.GetLength(0) - 1 - l; i++) //влево
            for (int j = array.GetLength(1) - 1 - 1 - l; j >= 0 + l; j--, count++)
                array[i, j] = count;

        for (int i = array.GetLength(0) - 1 - 1 - l; i >= 0 + 1 + l; i--) // вверх
            for (int j = 0 + l; j < 1 + l; j++, count++)
                array[i, j] = count;
    }
    
    if (array.GetLength(0) < array.GetLength(1) && array.GetLength(0) % 2 != 0 || array.GetLength(0) == array.GetLength(1)) // Заполняю пустоты неравномерности 2d массива
    {
        int k = array.GetLength(0) / 2;
        for (int i = 0 + k; i < 1 + k; i++)
            for (int j = 0 + k; j < array.GetLength(1) - k; j++, count++) 
                array[i, j] = count;
    }
    else if (array.GetLength(0) > array.GetLength(1) && array.GetLength(0) % 2 != 0 &&
             array.GetLength(0) > array.GetLength(1) && array.GetLength(1) % 2 != 0 ||
             array.GetLength(0) > array.GetLength(1) && array.GetLength(1) % 2 != 0   )
    {
        int m = array.GetLength(1) / 2;
        for (int i = m; i < array.GetLength(0) - m; i++)
            for (int j = array.GetLength(1) - 1 - m; j <= array.GetLength(1) - 1 - m; j++, count++)
                array[i, j] = count;
    }      
    return array;
}

Console.WriteLine("Здравствуй пользователь, эта программа которая заполнит массив 'M на N' по спирали");
Console.WriteLine("Рекомендуемо от 2х строк и стобцов, до 10 строк и 15 столбцов");

Console.Write("Введите количество строк M: ");
int m = Convert.ToInt32(Console.ReadLine());
if(m<0)
    m*=(-1);

Console.Write("Введите количество столбцов N: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n<0)
    n*=(-1);

int[,] myArray = GenerateCount2dArrayHelix(m, n);
Output2dArray(myArray);
*/


