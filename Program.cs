//Задача 34
//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int Quant(int[] array)
{
    int current = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
        {
            current ++;
        }
        return current;
}

Console.Write("number of elements = ");
int n = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(n);
ShowArray(myArray);
int quantity = Quant(myArray);
Console.WriteLine("Quantity of even numbers = " + quantity);
*/

//Задача 36
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int Sum(int[] array)
{
    int summa = 0;
    for(int i = 1; i < array.Length; i = i + 2)
    {
        summa = summa + array[i];
    }
    return summa;
}

Console.Write("number of elements = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("input min ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input max ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);

int result = Sum(myArray);
Console.WriteLine("Sum of elements = " + result);
*/

//Задача 38
//Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreateRandomArray(int size, int min, int max)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() + new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(Math.Round(array[i],3) + " ");
    }
    Console.WriteLine();
}

double Max(double[] array)
{
    double max = array[0];
    for(int i = 1; i < array.Length; i ++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double Min(double[] array)
{
    double min = array[0];
    for(int i = 1; i < array.Length; i ++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}
Console.Write("number of elements = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("input min border ");
int minBorder = Convert.ToInt32(Console.ReadLine());
Console.Write("input max border ");
int maxBorder = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(n, minBorder, maxBorder);
ShowArray(myArray);

double max = Max(myArray);
Console.WriteLine("max = " + Math.Round(max,3));

double min = Min(myArray);
Console.WriteLine("min = " + Math.Round(min,3));

Console.WriteLine("difference = " + Math.Round(max - min,3));
*/