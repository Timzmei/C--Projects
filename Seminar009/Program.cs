// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5" M = 4; N = 8 -> "4, 6, 7, 8"

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12 45 -> 9

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (35) A = 2; B = 3 -> 8


// Задача 63.
Console.WriteLine("Введите N");
int t = int.Parse(Console.ReadLine());
PrintNumber(100);
void PrintNumber( int i)
{
    if(i == t)
    {
        return;
    }
    Console.WriteLine(i);
    i++;
    PrintNumber(i);

}

// Задача 65.
Console.WriteLine("Введите N");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите M");
int m = int.Parse(Console.ReadLine());

void PrintNumberMN(int n, int m)
{
    if(i == n)
    {
        return;
    }
    Console.WriteLine(m);
    m++;
    PrintNumberMN(n, m);
}


// Задача 67
Console.WriteLine("Введите N");
int number = int.Parse(Console.ReadLine());
int sum = 0; 
Console.WriteLine(GetSumNumber(number));

int GetSumNumber(int number)
{
    if(number < 1)
    {
        return sum;
    }
    sum = sum + number % 10;       
    return GetSumNumber(number / 10);
}

// Задача 69:
Console.WriteLine("Введите A");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите B");
int b = int.Parse(Console.ReadLine());
int result = 1;
Console.WriteLine(GetExponentAB(a,b));

int GetExponentAB(int a, int b)
{
    if(b == 0)
    {
        return result;
    }

    result = result * a;
    b--;

    return GetExponentAB(a, b);

}
