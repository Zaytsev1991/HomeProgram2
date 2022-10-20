//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool Palindrom(int n)
{
    if (n % 10 == n / 10000 && (n / 10) % 10 == (n / 1000) % 10)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Push 5digit number  ");
int num = Convert.ToInt32(Console.ReadLine());
bool res = Palindrom(num);
Console.Write("Is it a palindrom?  " + res);
*/

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Lenght(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double lenght = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
    return lenght;
}
Console.Write("x1 = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1 = ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1 = ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("x2 = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2 = ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2 = ");
int z2 = Convert.ToInt32(Console.ReadLine());

double lenght = Lenght(x1, y1, z1, x2, y2, z2);
Console.WriteLine("lenght = " + Math.Round(lenght,3));
*/

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cube(int n)
{
    int current = 1;
    if (n < 1)
    {
        Console.WriteLine("Thank you, Mario! But your cubes are in another castle. Try something else NATURAL N");
    }
    else
    {
        while(current <= n)
        {
            Console.Write(Math.Pow(current,3) + " ");
            current++;
        }
    }
}

Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

Cube(n);
*/