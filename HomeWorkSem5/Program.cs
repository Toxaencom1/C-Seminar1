// Задача №1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.


void ArrayOutput(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i == (array.Length-1))
        {
            Console.Write($"{array[i]}");   
        }
        else
        {
            Console.Write($"{array[i]}, ");    
        }
    }
    Console.WriteLine("]");
}


/*
int[] ArrayPosRandomInput100Till1000(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
        {
            array[i] = new Random().Next(100,1000);
        }
    return array;
}    
*/

/*
int EvenNumbersOfArrayCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0)
        {
           count++; 
        }    
    }
    return count;
}
*/
/*
Console.WriteLine("Привет пользователь, эта программа считает количество случайных, четных, трехзначных элементов массива");
Console.WriteLine("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
if(length<0)
{
    length = length * (-1);
}
int[] myArray = ArrayPosRandomInput100Till1000(length);
ArrayOutput(myArray);
Console.WriteLine($"Число четных элементов массива: {EvenNumbersOfArrayCount(myArray)} ");

*/

// Задача №2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// P.S - Для задачи требуется метод ArrayOutput

/*
int[] ArrayRandomInput(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
        {
            array[i] = new Random().Next(-99,100);
        }
    return array;
}    



int SumOfUnEvenValueIndex(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum += array[i];
    }
    return sum;
}

Console.WriteLine("Привет пользователь, эта программа считает сумму случайных значений, нечетных позиций массива");
Console.WriteLine("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());

if(length<0)
    length = length * (-1);

int[] myArray = ArrayRandomInput(length);
ArrayOutput(myArray);
Console.WriteLine($"Сумма элементов массива на нечетных позициях равна: {SumOfUnEvenValueIndex(myArray)}");
*/

// Задача №3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


