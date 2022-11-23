// Задача 54: 
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

int[,] FromMaxToMin(int[,] array)
{
    int temp = 0;
    int[,] arrayDecreasing = new int[array.GetLength(0), array.GetLength(1)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for(int k = j + 1; k < array.GetLength(1); k++)
            {
                if(array[i, j] < array[i, k])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }

    }
    return arrayDecreasing;
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
Console.WriteLine("");
int[,] arr = FromMaxToMin(myArray);
Show2dArray(myArray);
*/

// Задача 56: 
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

int[] SumString(int[,] array)
{
    int[] arraysumstring = new int[array.GetLength(0)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            arraysumstring[i] += array[i,j];
        }
    }
    return arraysumstring;
}

int Min(int[] array)
{
    int min = array[0];
    int minindex = 0;
    for(int i = 1; i < array.Length; i ++)
    {
        if(array[i] < min)
        {
            min = array[i];
            minindex = i;
        }
    }
    Console.WriteLine("Minimal string number = " + (minindex + 1));
    return minindex;
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

int[] mySumArray = SumString(myArray);
Console.WriteLine("");

int minimum = Min(mySumArray);
*/

// Задача 58: 
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

int[,] MatrixMultiplex(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    if(array1.GetLength(1) == array2.GetLength(0))
    {
       for(int i = 0; i < array3.GetLength(0); i++) 
       {
            for(int j = 0; j < array3.GetLength(1); j++)
            {
                for (int k = 0; k < array1.GetLength(1); k++)
                {
                    array3[i, j] += array1[i, k] * array2[k, j];
                }
            }
       }
    }
    return array3;
}

Console.Write("Number rows 1 = ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Number columns 1 = ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Min value 1 = ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Max value 1 = ");
int max1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");

Console.Write("Number rows 2 = ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Number columns 2 = ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Min value 2 = ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Max value 2 = ");
int max2 = Convert.ToInt32(Console.ReadLine());

int[,] myArray1 = CreateRandom2dArray(m1, n1, min1, max1);
Show2dArray(myArray1);
Console.WriteLine("");
int[,] myArray2 = CreateRandom2dArray(m2, n2, min2, max2);
Show2dArray(myArray2);
Console.WriteLine("");
int[,] myArray3 = MatrixMultiplex(myArray1, myArray2);
Show2dArray(myArray3);
*/

// Задача 60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*
int[] CreateNoReplayArray(int min, int lenght)          // Данный метод если честно пришлось искать (225 - 245),                                                     
{                                                       // сам не смог придумать как создать
    int random = new Random().Next(min, min + lenght);  // неповторяющийся поэлементно одномерный массив. Но разобрался в нем от и до!
    int[] array = new int[lenght];                      // Всё остальное сам
    for (int i = 0; i < lenght; i++)
    {
        bool NoReplay;
        do
        {
            array[i] = new Random().Next(min, min + lenght);
            NoReplay = true;
            for (int j = 0; j < i; j++)
                if (array[i] == array[j])
                {
                    NoReplay = false;
                    break;
                }
        } while (NoReplay == false);
    }
    return array;
}

int[,,] CreateRandom3dArray(int abscissa, int ordinate, int applicate ,int[] arrayNoReplay)
{
    int[,,] array = new int[abscissa, ordinate, applicate];
    for(int i = 0, x=0; i < abscissa; i++)
    {
        for(int j = 0; j < ordinate; j++)
        {
            for(int k = 0; k < applicate; k++)
            {
                array[i,j,k] = arrayNoReplay[x++];
            }
        }
    }
    return array;
}

void Show3dArray(int[,,] array)
{
    for(int k = 0; k < array.GetLength(2); k++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i,j,k] + "(" + i + "," + j + "," + k + ")" + " ");
            }
            Console.WriteLine();
        }
    }
}

int min = 10;
int lenght = 90;
int[] myArray = CreateNoReplayArray(min, lenght);

Console.Write("Number rows in 1d = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Number columns in 2d = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Number shelfs in 3d = ");
int t = Convert.ToInt32(Console.ReadLine());

int[,,] myArray2 = CreateRandom3dArray(m, n, t, myArray);
Show3dArray(myArray2);
*/
