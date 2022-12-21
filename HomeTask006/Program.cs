
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Задача 41. Решение
using System.Text;

Console.WriteLine("Введите числа через пробел или запятую");

StringBuilder readNumbers = new StringBuilder(Console.ReadLine());
string[] array = readNumbers.Replace(",", " ").ToString().Split(" ",StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine(string.Join(", ",array));

Console.WriteLine("Число положительных чисел = " + GetCountNumbers(array));


// Задача 43. Решение
Console.WriteLine("Программа, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2\n");

double b1 = ReadNumber("Введите значение b1");
double k1 = ReadNumber("Введите значение k1");
double b2 = ReadNumber("Введите значение b2");
double k2 = ReadNumber("Введите значение k2");

Console.WriteLine(GetCross(k1, k2, b1, b2));

string GetCross(double k1, double k2, double b1, double b2)
{
    double paralels = (k2 - k1);
    if(paralels == 0)
    {
        return "Прямые не пересекаются, они параллельны";
    }
    double x = (b1 - b2) / paralels;

    Console.WriteLine("x= " + x);
    double y = k1 * x + b1;
    Console.WriteLine("y= " + y);

    return string.Join(";", new double[]{x, y});
}

int GetCountNumbers(string[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(int.Parse(array[i]) > 0)
        {
            count++;
        }
    }
    return count;

}

int ReadNumber(string text)
{
    Console.WriteLine(text);
    int number;
    string readNumber = Console.ReadLine() ?? "Nullable";
    if (int.TryParse(readNumber, out number)) { }
    else
    {
        Console.WriteLine("Ввод некорректный. Вводите только цифры");
        number = ReadNumber(text);
    }
    return number;
}


