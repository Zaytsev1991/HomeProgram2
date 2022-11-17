//Задача 47. 
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().NextDouble() + new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i,j],3) + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Number rows = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Number columns = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Min value = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Max value = ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
*/

//Задача 50. 
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void Position(int[,] array, int posRow, int posColumn)
{
    if(posRow < array.GetLength(0) && posColumn < array.GetLength(1))
    {
        Console.WriteLine("Element = " + array[posRow,posColumn]);
    }
    else
    {
        Console.WriteLine("This element does not exist");
    }
}

Console.Write("Number rows = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Number columns = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Min value = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Max value = ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

Console.Write("Input position of row = ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input position of column = ");
int column = Convert.ToInt32(Console.ReadLine());
Position(myArray, row, column);
*/

//Задача 52. 
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
double[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

double[] AverRes(double[,] array)
{
    double[] arraydouble = new double[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            arraydouble[j] = array[i,j]/array.GetLength(0) + arraydouble[j];
        }
    }
    return arraydouble;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(Math.Round(array[i],3) + " ");
    }
    Console.WriteLine();
}

Console.Write("Number rows = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Number columns = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Min value = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Max value = ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
double[] myDoubleArray = AverRes(myArray);
ShowArray(myDoubleArray);
*/