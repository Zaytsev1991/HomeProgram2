//Задача 10
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondNumber(int number)
{
    int twodigit = number / 10;
    int result = twodigit % 10;
    return result;
}

Console.Write("threedigit number = ");
int num = Convert.ToInt32(Console.ReadLine());

int second = SecondNumber(num);

Console.WriteLine("The Second Number " + second);
*/


//Задача 13
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
/*
int ThirdNumber(int number)
{
    int threedigit = number / 100;
    int result = threedigit % 10;
    return result;
}
 
Console.Write("Push number = ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99)
{
    num = ThirdNumber(num);
    Console.WriteLine("Third Number = " + num);
}
else
{
    Console.WriteLine("We haven't third number");
}
*/

//Задача 15
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

/*
bool WeekNumber(int n)
{
    if (n == 6 || n == 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Push number of the day of the week  ");
int day = Convert.ToInt32(Console.ReadLine());
bool res = WeekNumber(day);
Console.Write("Is it a day off?  " + res);
*/
