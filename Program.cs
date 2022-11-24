// Задача 64: 
// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNumbers(int n)
{
    Console.Write(n + " ");
    if(n > 1) ShowNumbers(n - 1);

}
Console.Write("N = ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNumbers(n);
*/

// Задача 66: 
// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int ShowNumbers(int n, int m)
{
    if(n > m) 
    {
        return ShowNumbers(n - 1, m) + n;
    }
    else
    {
        if(n < m)
        { 
            return ShowNumbers(m - 1, n) + m;
        }
    }
    return n;
}
Console.Write("N = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ShowNumbers(n, m));
*/

// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
/*
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if ((m > 0) && (n == 0))
        {
            return Akkerman(m - 1, 1);
        }
        else
        {
            return Akkerman(m - 1, Akkerman(m, n - 1));
        }
    }
}
 
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Akkerman(m, n)); 
*/