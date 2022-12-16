// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 45 -> 101101
// 3 -> 11
// 2 -> 10

// Задача 44: Не используя рекурсию, выведите первые
// N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и
// 1.
// Если N = 5 -> 0 1 1 2 3 
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью
// поэлементного копирования.

int a = ReadNumber("Введите первую сторону треугольника");
int b = ReadNumber("Введите вторую сторону треугольника");
int c = ReadNumber("Введите третью сторону треугольника");

// Задача 42
Console.WriteLine(GetTriangle(a, b, c));

Console.WriteLine("Введите число");
string readNumber = Console.ReadLine();
string result = "";

Console.WriteLine(GetBinaryNumber(readNumber, result));


// Задача 44
int a = ReadNumber("Введите число");


// Задача 45:
int lengthArray = ReadNumber("Введите длину массива: ");
Console.WriteLine("Длина массива = " + lengthArray);
int[] array = CreateArray(lengthArray, 1, 20);


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


bool GetTriangle(int a, int b, int c)
{
    if (a + b > c && a + c > b && b + c > a)
    {
        return true;
    }
    return false;
}


string GetBinaryNumber(string a, string result)
{
    int number = int.Parse(a);
    while (number > 0)
    {
        result = (number % 2).ToString() + result;
        number = number / 2;
    }
    // if (number == 1)
    // {
    //     result = result + "1";
    // }
    return result;
}


int[] GetFibonachi(int number)
{
    int[] result = new int[number];
    int n1 = 0;
    int n2 = 1;
    if (number > 0)
    {
        result[0] = n1;
    }
    if (number > 1)
    {
        result[1] = n2;
    }
    for (int i = 2; i <= number; i++) ;
    {
        result[i] = result[i - 1] + result[i - 2];
    }
    return result;
}

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}