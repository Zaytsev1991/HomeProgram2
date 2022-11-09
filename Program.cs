//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
Console.Write("number A = ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("number B = ");
int b = Convert.ToInt32(Console.ReadLine());

int current = 1;
int a1 = a;

while(current < b)
{
    a *= a1;
    current++;
}

Console.WriteLine("Result = "+ a);

*/


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int Quant(int number)
{
    int sum = 0;
    while(number != 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    return sum;
}

Console.Write("number = ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"quantity = {Quant(num)}");
*/