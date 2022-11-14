//Задача 41
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
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

int positiveElements(int[] array)
{
    int quantity = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            quantity++;
        }
    }
    return quantity;
}

Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(m);
Console.Write("Your array ");
ShowArray(myArray);

int quant = positiveElements(myArray);
Console.WriteLine("Number of positive elements = " + quant);
*/

//Задача 43
//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

/*
Console.WriteLine("Enter a parameters of the lines type of y = k*x + b ");

void LinesIntersection(double k1, double b1, double k2, double b2)
{
    if(k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Lines match");
    }
    else
    {
        if(k1 == k2)
        {
            Console.WriteLine("Lines parallel");
        }
        else
        {
            double x = (b2 - b1)/(k1 - k2);
            double y = k1 * x + b1;
            Console.WriteLine("Coordinate of the intersection point");
            Console.WriteLine("x = " + Math.Round(x,3) + " y = " + Math.Round(y,3));
        }
    }
} 

Console.Write("k1 = ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b1 = ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToInt32(Console.ReadLine());

LinesIntersection(k1, b1, k2, b2);
*/