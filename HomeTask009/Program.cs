// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Задача 64.
Console.WriteLine("\n\nЗадача 64");
Console.WriteLine("Программа, которая выведет все натуральные числа в промежутке от N до 1");
Console.WriteLine("Введите N");
int number = int.Parse(Console.ReadLine());
PrintNumber(number);
void PrintNumber(int i)
{
    if (i == 1)
    {
        Console.WriteLine(i);
        return;
    }
    Console.Write($"{i}, ");
    i--;
    PrintNumber(i);

}

// Задача 66
Console.WriteLine("\n\nЗадача 66");
Console.WriteLine("Программа вычисления функции Аккермана");
Console.WriteLine("Введите N");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите M");
int m = int.Parse(Console.ReadLine());
int result = 0;
Console.WriteLine(Sum(n, m));

int Sum(int n, int m)
{
    if (m <= n)
        return n;
    return m + Sum(n, m - 1);
}

// Задача 68
Console.WriteLine("\n\nЗадача 68");
Console.WriteLine("Программа, которая найдёт сумму натуральных элементов в промежутке от M до N");
Console.WriteLine("Вычисление функции Аккермана");
Console.WriteLine("Введите N");
int j = int.Parse(Console.ReadLine());
Console.WriteLine("Введите M");
int k = int.Parse(Console.ReadLine());
Console.WriteLine(Akkerman(j,k));

int Akkerman(int n, int m)
{
    if (n == 0)
    {
       return m + 1; 
    } else
    {
        if ((n != 0) && (m == 0))
        {
            return Akkerman(n - 1, 1);
        }else
        {
           return Akkerman(n - 1, Akkerman(n, m - 1)); 
        }
    }
}